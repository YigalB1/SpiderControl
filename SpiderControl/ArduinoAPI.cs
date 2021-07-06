using System.IO.Ports;

namespace SpiderControl
{

    struct Arduino_Servo_cmd_struct
    {
        public bool valid; // if starting with # it is a comment
        public int servo_num;
        public int servo_angle;
        public int wait_time;
    }



    public class Spider_Servo
    {
        private Arduino_Servo_cmd_struct Servo_cmd;
        private Arduino_Serial_Port Servo_port;

        public Spider_Servo(bool valid, int servo_num, int servo_angle, int wait_time)
        {
            this.Servo_cmd.valid = valid;
            this.Servo_cmd.servo_num = servo_num;
            this.Servo_cmd.servo_angle = servo_angle;
            this.Servo_cmd.wait_time = wait_time;

            Servo_port = new Arduino_Serial_Port();
        }

    } 

    public class Arduino_Serial_Port
    {
        private SerialPort arduino_port = new SerialPort();



        public Arduino_Serial_Port()
        {/*
            arduino_port.PortName = SetPortName(_serialPort.PortName);
            arduino_port..BaudRate = SetPortBaudRate(_serialPort.BaudRate);
            arduino_port..Parity = SetPortParity(_serialPort.Parity);
            arduino_port..DataBits = SetPortDataBits(_serialPort.DataBits);
            arduino_port..StopBits = SetPortStopBits(_serialPort.StopBits);
            arduino_port..Handshake = SetPortHandshake(_serialPort.Handshake);
            */
        }
        public void set_port()
        {
            //arduino_port.PortName = Form1.
        }
    } // of Arduino_Serial_port


}
