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
        // global variables, Yigal 10 July 2021
        string work_path = "C:\\Users\\NH10\\Documents\\Visual Studio 2019\\repos\\SpiderControl\\";
        string spider_comands_fname = "spider_commands.txt";



        String[] PortNames = System.IO.Ports.SerialPort.GetPortNames();
        Spider_Anatomy my_spider = new Spider_Anatomy();
        static ControlAPI my_control = new ControlAPI();
        string cmd_file = "";
        List<Control_Command> cmds;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // ******************* handle ports
            try
            {
                /*
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
                */


            } // of try

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } // of catch




            // ******************* read command file    
            try
            {
                // read source file with commands to servo

                //cmd_file = my_control.Set_files("C:\\Users\\NH10\\Documents\\Visual Studio 2019\\repos\\SpiderControl\\", "spider_commands.txt");  // Yigal 10 July 2021
                cmd_file = my_control.Set_files(work_path, spider_comands_fname);
                if (cmd_file != "")
                    cmds = my_control.Parse_cmd_file(cmd_file);
            } // of try
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } // of catch
        }


        private void OnButton_Click(object sender, EventArgs e)
        {
            try
            {
                Console.WriteLine("ON: serialPort1.BaudRate = " + serialPort1.BaudRate.ToString());
                Console.WriteLine("ON: serialPort1.ReadTimeout = " + serialPort1.ReadTimeout.ToString());
                Console.WriteLine("ON: serialPort1.WriteTimeout = " + serialPort1.WriteTimeout.ToString());
                Console.WriteLine("OFF: serialPort1.PortName = " + serialPort1.PortName);




                serialPort1.Open();
                serialPort1.Write("1");
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
                Console.WriteLine("OFF: serialPort1.BaudRate = " + serialPort1.BaudRate.ToString());
                Console.WriteLine("OFF: serialPort1.ReadTimeout = " + serialPort1.ReadTimeout.ToString());
                Console.WriteLine("OFF: serialPort1.WriteTimeout = " + serialPort1.WriteTimeout.ToString());
                Console.WriteLine("OFF: serialPort1.PortName = " + serialPort1.PortName   );

                serialPort1.Open();
                serialPort1.Write("0");
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
            // yigal 10 July 2021
            try
            {
                // read source file with commands to servo

                cmd_file = my_control.Set_files(work_path, spider_comands_fname);

                Console.WriteLine("work_path: " + work_path);
                Console.WriteLine("spider_comands_fname: " + spider_comands_fname);
                Console.WriteLine("cmd_file: " + cmd_file);

                if (cmd_file != "")
                    cmds = my_control.Parse_cmd_file(cmd_file);
            } // of try
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } // of catch

            // finished parsing the commands
            Console.WriteLine("finished parsing commands file");
        }

        private void Init_button_Click(object sender, EventArgs e)
        {
            // TBD - init from here, instead from form load
            String[] pc_PortNames = System.IO.Ports.SerialPort.GetPortNames();
            int num_of_ports = pc_PortNames.Count();
            Console.Write("Num of ports: ");
            NumOfPortsTextBox.Text = num_of_ports.ToString();

            switch (num_of_ports)
            {
                case 0:
                    NumOfPortsTextBox.BackColor = Color.Red;
                    NumOfPortsTextBox.TextAlign = HorizontalAlignment.Center;
                    NumOfPortsTextBox.ForeColor = Color.White;
                    break;
                case 1:
                    NumOfPortsTextBox.BackColor = Color.Green;
                    NumOfPortsTextBox.ForeColor = Color.White;
                    break;
                default:
                    NumOfPortsTextBox.BackColor = Color.Yellow;
                    NumOfPortsTextBox.ForeColor = Color.Black;
                    break;
            }

            if (num_of_ports == 0) 
            {
                MessageBox.Show("No Arduino was detected");
                return;
            }

            // we have at least one serial communication port on USB


            

            Console.WriteLine(num_of_ports.ToString());
            Console.Write("Available ports:  ");
            foreach (string s in PortNames)
            {
                Console.Write("   {0}", s);
            }
            Console.WriteLine(" ");


            // display the avilable port(s) in th drop down menu
            PortBox.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
            //int  x = System.IO.
            //Debug.WriteLine(x.ToString());
            PortBox.SelectedIndex = 0;
            serialPort1.BaudRate = (9600);
            serialPort1.ReadTimeout = (2000);
            serialPort1.WriteTimeout = (2000);

            // send a message to the serial port
            //serialPort1.Open();
            //serialPort1.Write("12345"); // each message starts with $and ends with & ("$ hello &")
            //serialPort1.Close();
            
           


        } // of Init_button_Click()
    } // of forms1
}
