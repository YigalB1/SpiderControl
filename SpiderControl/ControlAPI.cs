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
            //Console.WriteLine(cmd_file_fname); // just for debug

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
