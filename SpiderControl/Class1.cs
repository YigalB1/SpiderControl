using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SpiderControl
{

    struct Servo_cmd
    {
        public bool valid; // if starting with # it is a comment
        public int servo_num;
        public int servo_angle;
        public int wait_time;
    }

    public class Spider_class
    {
        Leg_class Left_Leg_1 = new Leg_class();
        Leg_class Left_Leg_2 = new Leg_class();
        Leg_class Left_Leg_3 = new Leg_class();
        Leg_class Right_Leg_1 = new Leg_class();
        Leg_class Right_Leg_2 = new Leg_class();
        Leg_class Right_Leg_3 = new Leg_class();
        Spider_Command_file_class Input_cmd_file = new Spider_Command_file_class();
    } // of Spider_class


    public class Leg_class
    {
        Servo_class servo_1 = new Servo_class();
        Servo_class servo_2 = new Servo_class();
        Servo_class servo_3 = new Servo_class();
    } // of Leg_class



    public class Servo_class
    {
        
        
    } // of Servo_class


    public class Spider_Command_file_class
    {
        string cmd_file_path = null;
        string cmd_file_fname = null;

        public bool Set_files(string _path, string _fname)
        {
            cmd_file_path = _path;
            cmd_file_fname = _path + _fname;
            Console.WriteLine(cmd_file_fname); // just for debug

            if (!Directory.Exists(cmd_file_path))
            {
                MessageBox.Show("No such directory");
                return false;
            }

            if (!File.Exists(cmd_file_fname))
            {
                MessageBox.Show("No such file");
                return false;
            }
            Console.WriteLine("file exists");

            return true;

        } // of Set_files


        public void Parse_cmd_file()
        {
            
            string[] lines = System.IO.File.ReadAllLines(cmd_file_fname);
            Console.WriteLine("num of lines in command file: " + lines.Length.ToString());
            List<Servo_cmd> servo_commands_list = new List<Servo_cmd>();
            Servo_cmd servo_command = new Servo_cmd();
            int line_num = 0;

            foreach (string line in lines)
            {
                line_num++;
                // Use a tab to indent each line of the file.
                Console.WriteLine("\t" + line);
                if (String.Compare(line.Substring(0, 1), "#") == 0)
                {
                    continue; // it is a comment
                } // of if

                string[] words = line.Split(' '); // split a single line into words.
                if (words.Length!=3)
                {
                    Console.WriteLine("Error: line num " + line_num + " needs exacly 3 words" + line);
                    continue;
                }

                // TBD: parse the command, add to list, return the list tp main.



            }


        }




    } // of Spider_Command_file_class


} // of namespace SpiderControl




