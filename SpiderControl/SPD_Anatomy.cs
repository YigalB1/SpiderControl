using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiderControl
{

    class SPD_leg
    {
        private int SPD_leg_angle ;  // Legal values 0-179 degrees

        public SPD_leg()        // Constructor - place holder
        {
            SPD_leg_angle = 40;
        }

        public void SetAngle(int SPD_leg_angle) {
            if (SPD_leg_angle < 0) SPD_leg_angle = 0;
            if (SPD_leg_angle > 179) SPD_leg_angle = 179;
            this.SPD_leg_angle = SPD_leg_angle; }
        public int GetAngle()  { return this.SPD_leg_angle; }


    }


    class SPD_Anatomy
    {
        private SPD_leg[] Legs = new SPD_leg[6];

        public SPD_Anatomy()    // Constructor
        {
            for (int  i = 0;  i < Legs.Length;  i++)
            {
                Legs[i] = new SPD_leg();
            }
        }

        public bool MoveForwordOneStep()
        {
            int[] steps4A_step = {90, 90, 90, 90, 90, 90};  // Get down, just to see controls are workgin
            return true;
        }
    }
}
