using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;

namespace SpiderControl
{

    public class Spider_Leg
    {
        Spider_Servo[] Leg= new Spider_Servo[3];  // TBD: change name to motor, because each leg has 3 motors
        int LegNum;
        public Spider_Leg(int LegNum)
        {
            this.LegNum = LegNum;
            for (int i = 0; i < Leg.Length; i++)
            {   // valid, servo_num, servo_angle, wait_time
                Leg[i] = new Spider_Servo(true, LegNum*10 + i, 90, 0); }
        } // of Leg_class
    }

    public class Spider_Anatomy
    {   // Legs 0,1,2 are on left size, 3,4,5 on right. 0 - 3 are on the front
        Spider_Leg[] Legs = new Spider_Leg[6];

        public Spider_Anatomy()
        {
            for (int i = 0; i < Legs.Length; i++)
            {
                Legs[i] = new Spider_Leg(i);
            }
        }
        //Spider_Command_file_class Input_cmd_file = new Spider_Command_file_class();
    } // of Spider_class


} // of namespace SpiderControl




