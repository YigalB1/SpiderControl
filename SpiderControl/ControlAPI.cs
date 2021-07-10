using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace SpiderControl
{

    class Control_Command
    {
        public int SpiderNum;
        public int SpiderLeg;
        public bool valid;
        public int servo_num;
        public int servo_angle;
        public int wait_time;
    }

    class ControlAPI
    {
        // Check if there is a file in the spefied position. If no - return empty string, else return the full path of the file

       

        public string Set_files(string _path, string _fname)
        {
            string cmd_file_path ;
            string cmd_file_fname ;

            cmd_file_path = _path;
            cmd_file_fname = _path + _fname;
            Console.WriteLine(cmd_file_fname); // just for debug
         



            if (!Directory.Exists(cmd_file_path)) {MessageBox.Show("No such directory");  return ""; }
            if (!File.Exists(cmd_file_fname))     {MessageBox.Show("No such file");       return ""; }
            
            //Console.WriteLine("file exists");
            return cmd_file_fname;
        } // of Set_files




        // Read a command list from a text file into a List.
        // Commands are int the format (delimiter Space):
        // <SpiderNum> <SpiderLeg> <SpiderLegServo : <valid> <servo_num> <servo_angle> <wait_time>>
        // Ex:   0          3                         True        31           90         0
        // SpiderNum = 9 is a remark line. Must be in position 0
        public List<Control_Command> Parse_cmd_file(string cmd_file_fname)
        {
            string[] lines = System.IO.File.ReadAllLines(cmd_file_fname);
            //Console.WriteLine("num of lines in command file: " + lines.Length.ToString());
            var commands = new List<Control_Command>(); // Yigal 10 July 2021
            var command_tmp = new Control_Command(); 

            // Yigal 10 July 2021
            foreach (string line in lines)
            {
                // remove comments
                if (line.IndexOf("#") == 0)
                    continue;
                
                string[] words = line.Split();
                if (words.Count() != 3)
                    continue; // each command line has 3 parameters (servo num, Angle, wait time)

                

                // analyze the commands, make sure no mistakes 
                    if ((words[0].IndexOf("S") != 0) || (words[1].IndexOf("A") != 0) || (words[2].IndexOf("T") != 0))
                        continue; // commands must start with S, then A, then T
              
                // now parse the commands details  - remove the command letter 
                words[0] = words[0].Replace("S", "");
                words[1] = words[1].Replace("A", "");
                words[2] = words[2].Replace("T", "");

                try
                {

                    // declaring Int16 variable
                    short servo_num;
                    short angle_val;
                    short wait_time_val;

                    // getting parsed value
                    servo_num = Int16.Parse(words[0]);
                    angle_val = Int16.Parse(words[1]);
                    wait_time_val = Int16.Parse(words[2]);

                    
                    command_tmp.servo_num = servo_num;
                    command_tmp.servo_angle = angle_val;
                    command_tmp.wait_time = wait_time_val;
                    commands.Add(command_tmp);


                    Console.Write(servo_num.ToString() + " /");
                    Console.Write(angle_val.ToString() + " /");
                    Console.Write(wait_time_val.ToString() + " /");
                    Console.WriteLine(" ");

                }

                catch (FormatException)
                {
                    Console.Write("Can't Parse line ");
                    foreach(string val in words)
                    {
                        Console.Write(val);
                    }
                    Console.WriteLine(" ");
                }



                

                foreach (string word in words) // for debug
                {
                    Console.Write(word + "/");
                }
                Console.WriteLine(" ");







            }
            
            return commands;

                

           

            var cmds = (from s in lines
                        let split = s.Split(' ')
                        select new Control_Command
                        {
                            SpiderNum = int.Parse(split.First()),
                            SpiderLeg = int.Parse(split.Skip(1).FirstOrDefault() ?? ""),
                            valid = bool.Parse(split.Skip(2).FirstOrDefault() ?? ""),
                            servo_num = int.Parse(split.Skip(3).FirstOrDefault() ?? ""),
                            servo_angle = int.Parse(split.Skip(4).FirstOrDefault() ?? ""),
                            wait_time = int.Parse(split.Skip(5).FirstOrDefault() ?? ""),
                        }).ToList();
            return cmds;
        }
    }
}
