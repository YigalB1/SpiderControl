using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Diagnostics;

namespace SpiderControl
{

    struct Servo_cmd
    {
        public bool valid; // if starting with # it is a comment
        public int servo_num;
        public int servo_angle;
        public int wait_time;
    }

    public partial class Form1 : Form
    {
        String[] PortNames = System.IO.Ports.SerialPort.GetPortNames();
        Spider_class my_spider = new Spider_class();
        


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            try
            {
                // handle ports
                
                int num_of_ports = PortNames.Count();
                Console.Write("Num of ports: ");
                NumOfPortsTextBox.Text = num_of_ports.ToString();
                Console.WriteLine(num_of_ports.ToString());
                Console.Write("Available ports:  ");
                foreach (string s in PortNames)
                {
                    Console.Write("   {0}", s);
                }
                Console.WriteLine(" ");

                PortBox.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
                //int  x = System.IO.
                //Debug.WriteLine(x.ToString());
                PortBox.SelectedIndex = 0;
                serialPort1.BaudRate = (9600);
                serialPort1.ReadTimeout = (2000);
                serialPort1.WriteTimeout = (2000);

                // read source file with commands to servo
                

                string spider_control_path = "C:\\Users\\NH10\\Documents\\Visual Studio 2019\\repos\\SpiderControl\\";
                string spider_control_fname = "spider_control.txt";
                string spider_control_file = spider_control_path + spider_control_fname;

               

                Console.Write(spider_control_path);
                Console.Write(" + ");
                Console.WriteLine(spider_control_fname);
                Console.Write(" = ");
                Console.WriteLine(spider_control_file);

                // Read each line of the file into a string array. Each element
                // of the array is one line of the file.
                string[] lines = System.IO.File.ReadAllLines(@spider_control_file);
                // now we have the command file read lines (array of strings)


                // Display the file contents by using a foreach loop.
                System.Console.WriteLine("Contents of WriteLines2.txt = ");

                Servo_cmd servo_command = new Servo_cmd();

                foreach (string line in lines)
                {
                    // Use a tab to indent each line of the file.
                    Console.WriteLine("\t" + line);
                    servo_command = parse_line(line);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        Servo_cmd parse_line(string line_in)
        {
            Servo_cmd servo_cmd_tmp = new Servo_cmd();
            servo_cmd_tmp.valid = false; // until check for no errors

            if (String.Compare(line_in.Substring(0, 1), "#") == 0)
            {                
                return (servo_cmd_tmp);
            } // of if
                
            servo_cmd_tmp.valid = true;

            Console.Write("in line: ");
            Console.Write(line_in);
            string[] words = line_in.Split(' ');
            Console.Write("   num of inputs in line: ");
            Console.WriteLine(words.Count());

            // print them all for debug
            foreach (var word in words)
            {
                Console.WriteLine($"<{word}>");
            } // of foreach

            //servo_cmd_tmp.

            servo_cmd_tmp.valid = true;
            return (servo_cmd_tmp);

        } // of parse_line()



        private void OnButton_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Open();
                serialPort1.WriteLine("On");
                serialPort1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OffButton_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Open();
                serialPort1.WriteLine("Off");
                serialPort1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PortBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = PortBox.Text;
                //MessageBox.Show(PortBox.);
                //MessageBox.Show(PortBox.Parent.ToString);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NumOfPortsLabel_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void Read_command_file_Click(object sender, EventArgs e)
        {
            
        }
    } // of forms1
}
