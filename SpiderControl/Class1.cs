using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiderControl
{
    public class Spider_class
    {

    } // of Spider_class


    public class Leg_class
    {
        Servo_class servo_servo_1 = new Servo_class();
        Servo_class servo_servo_2 = new Servo_class();
        Servo_class servo_servo_3 = new Servo_class();
    } // of Leg_class



    public class Servo_class
    {
        private Servo_cmd tmp_servo_cmd = new Servo_cmd();
        
    } // of Servo_class


    public class Command_file_class
    {

        public void Parse_file(string _path_to_file)
        {
            // Read each line of the file into a string array. Each element
            // of the array is one line of the file.
            string[] lines = System.IO.File.ReadAllLines(_path_to_file);
        }


    } // of Leg_class


}
