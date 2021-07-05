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
   
    public partial class Form1 : Form
    {
        String[] PortNames = System.IO.Ports.SerialPort.GetPortNames();
        Spider_class my_spider = new Spider_class();
        Spider_Command_file_class spider_files = new Spider_Command_file_class();
        


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // ******************* handle ports
            try
            {
                
                
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
            } // of try

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } // of catch




            // ******************* read command file    
            try
            {
                // read source file with commands to servo
                


                string spider_control_path = "C:\\Users\\NH10\\Documents\\Visual Studio 2019\\repos\\SpiderControl\\";
                string spider_control_fname = "spider_control.txt";
                spider_files.Set_files(spider_control_path, spider_control_fname);


            } // of try
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } // of catch
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
            spider_files.Parse_cmd_file();
        }
    } // of forms1
}
