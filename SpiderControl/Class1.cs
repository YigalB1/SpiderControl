using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiderControl
{
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
        
       
        public bool Serial_Port_control()
        {    


            return false;
        } // of Serial_Port_control


    } // of Spider_Command_file_class


} // of namespace SpiderControl




