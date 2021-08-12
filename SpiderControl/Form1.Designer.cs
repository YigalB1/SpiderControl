
namespace SpiderControl
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PortBox = new System.Windows.Forms.ComboBox();
            this.OnButton = new System.Windows.Forms.Button();
            this.OffButton = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.ExitButton = new System.Windows.Forms.Button();
            this.NumOfPortsTextBox = new System.Windows.Forms.TextBox();
            this.NumOfPortsLabel = new System.Windows.Forms.Label();
            this.Read_command_file = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Init_button = new System.Windows.Forms.Button();
            this.Connect_to_Arduino = new System.Windows.Forms.Button();
            this.RecievedDataBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SenderTextBox = new System.Windows.Forms.TextBox();
            this.SendCommand = new System.Windows.Forms.Button();
            this.ServoMinus90 = new System.Windows.Forms.Button();
            this.ServoZero = new System.Windows.Forms.Button();
            this.ServoPlus90 = new System.Windows.Forms.Button();
            this.ServoSwing = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Servo_activities_label = new System.Windows.Forms.Label();
            this.ServosComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // PortBox
            // 
            this.PortBox.FormattingEnabled = true;
            this.PortBox.Location = new System.Drawing.Point(130, 71);
            this.PortBox.Name = "PortBox";
            this.PortBox.Size = new System.Drawing.Size(121, 21);
            this.PortBox.TabIndex = 0;
            this.PortBox.SelectedIndexChanged += new System.EventHandler(this.PortBox_SelectedIndexChanged);
            // 
            // OnButton
            // 
            this.OnButton.Location = new System.Drawing.Point(129, 356);
            this.OnButton.Name = "OnButton";
            this.OnButton.Size = new System.Drawing.Size(121, 23);
            this.OnButton.TabIndex = 1;
            this.OnButton.Text = "ON";
            this.OnButton.UseVisualStyleBackColor = true;
            this.OnButton.Click += new System.EventHandler(this.OnButton_Click);
            // 
            // OffButton
            // 
            this.OffButton.Location = new System.Drawing.Point(130, 395);
            this.OffButton.Name = "OffButton";
            this.OffButton.Size = new System.Drawing.Size(121, 23);
            this.OffButton.TabIndex = 2;
            this.OffButton.Text = "OFF";
            this.OffButton.UseVisualStyleBackColor = true;
            this.OffButton.Click += new System.EventHandler(this.OffButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(574, 305);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(163, 103);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // NumOfPortsTextBox
            // 
            this.NumOfPortsTextBox.Location = new System.Drawing.Point(144, 12);
            this.NumOfPortsTextBox.Multiline = true;
            this.NumOfPortsTextBox.Name = "NumOfPortsTextBox";
            this.NumOfPortsTextBox.Size = new System.Drawing.Size(60, 36);
            this.NumOfPortsTextBox.TabIndex = 4;
            // 
            // NumOfPortsLabel
            // 
            this.NumOfPortsLabel.AutoSize = true;
            this.NumOfPortsLabel.Location = new System.Drawing.Point(44, 20);
            this.NumOfPortsLabel.Name = "NumOfPortsLabel";
            this.NumOfPortsLabel.Size = new System.Drawing.Size(94, 13);
            this.NumOfPortsLabel.TabIndex = 5;
            this.NumOfPortsLabel.Text = "Num of COM ports";
            this.NumOfPortsLabel.Click += new System.EventHandler(this.NumOfPortsLabel_Click);
            // 
            // Read_command_file
            // 
            this.Read_command_file.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Read_command_file.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.Read_command_file.Location = new System.Drawing.Point(129, 323);
            this.Read_command_file.Name = "Read_command_file";
            this.Read_command_file.Size = new System.Drawing.Size(121, 27);
            this.Read_command_file.TabIndex = 6;
            this.Read_command_file.Text = "Read Command File";
            this.Read_command_file.UseVisualStyleBackColor = false;
            this.Read_command_file.Click += new System.EventHandler(this.Read_command_file_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Selected port";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Init_button
            // 
            this.Init_button.Location = new System.Drawing.Point(47, 111);
            this.Init_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Init_button.Name = "Init_button";
            this.Init_button.Size = new System.Drawing.Size(117, 23);
            this.Init_button.TabIndex = 9;
            this.Init_button.Text = "Init Com port";
            this.Init_button.UseVisualStyleBackColor = true;
            this.Init_button.Click += new System.EventHandler(this.Init_button_Click);
            // 
            // Connect_to_Arduino
            // 
            this.Connect_to_Arduino.Location = new System.Drawing.Point(187, 111);
            this.Connect_to_Arduino.Name = "Connect_to_Arduino";
            this.Connect_to_Arduino.Size = new System.Drawing.Size(117, 23);
            this.Connect_to_Arduino.TabIndex = 10;
            this.Connect_to_Arduino.Text = "Connect";
            this.Connect_to_Arduino.UseVisualStyleBackColor = true;
            this.Connect_to_Arduino.Click += new System.EventHandler(this.button1_Click);
            // 
            // RecievedDataBox
            // 
            this.RecievedDataBox.Location = new System.Drawing.Point(363, 27);
            this.RecievedDataBox.Multiline = true;
            this.RecievedDataBox.Name = "RecievedDataBox";
            this.RecievedDataBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.RecievedDataBox.Size = new System.Drawing.Size(288, 164);
            this.RecievedDataBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(360, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Data from Arduino";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(360, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Command to Arduino";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // SenderTextBox
            // 
            this.SenderTextBox.Location = new System.Drawing.Point(363, 227);
            this.SenderTextBox.Name = "SenderTextBox";
            this.SenderTextBox.Size = new System.Drawing.Size(288, 20);
            this.SenderTextBox.TabIndex = 14;
            // 
            // SendCommand
            // 
            this.SendCommand.Location = new System.Drawing.Point(363, 254);
            this.SendCommand.Name = "SendCommand";
            this.SendCommand.Size = new System.Drawing.Size(121, 23);
            this.SendCommand.TabIndex = 15;
            this.SendCommand.Text = "Send Command";
            this.SendCommand.UseVisualStyleBackColor = true;
            this.SendCommand.Click += new System.EventHandler(this.SendCommand_Click);
            // 
            // ServoMinus90
            // 
            this.ServoMinus90.Location = new System.Drawing.Point(47, 203);
            this.ServoMinus90.Name = "ServoMinus90";
            this.ServoMinus90.Size = new System.Drawing.Size(52, 23);
            this.ServoMinus90.TabIndex = 16;
            this.ServoMinus90.Text = "-90";
            this.ServoMinus90.UseVisualStyleBackColor = true;
            // 
            // ServoZero
            // 
            this.ServoZero.Location = new System.Drawing.Point(105, 203);
            this.ServoZero.Name = "ServoZero";
            this.ServoZero.Size = new System.Drawing.Size(52, 23);
            this.ServoZero.TabIndex = 17;
            this.ServoZero.Text = "Zero";
            this.ServoZero.UseVisualStyleBackColor = true;
            // 
            // ServoPlus90
            // 
            this.ServoPlus90.Location = new System.Drawing.Point(163, 204);
            this.ServoPlus90.Name = "ServoPlus90";
            this.ServoPlus90.Size = new System.Drawing.Size(52, 23);
            this.ServoPlus90.TabIndex = 18;
            this.ServoPlus90.Text = "+90";
            this.ServoPlus90.UseVisualStyleBackColor = true;
            // 
            // ServoSwing
            // 
            this.ServoSwing.Location = new System.Drawing.Point(221, 204);
            this.ServoSwing.Name = "ServoSwing";
            this.ServoSwing.Size = new System.Drawing.Size(52, 23);
            this.ServoSwing.TabIndex = 19;
            this.ServoSwing.Text = "Swing";
            this.ServoSwing.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "label4";
            // 
            // Servo_activities_label
            // 
            this.Servo_activities_label.AutoSize = true;
            this.Servo_activities_label.Location = new System.Drawing.Point(47, 177);
            this.Servo_activities_label.Name = "Servo_activities_label";
            this.Servo_activities_label.Size = new System.Drawing.Size(80, 13);
            this.Servo_activities_label.TabIndex = 21;
            this.Servo_activities_label.Text = "Servo Activities";
            // 
            // ServosComboBox
            // 
            this.ServosComboBox.FormattingEnabled = true;
            this.ServosComboBox.Location = new System.Drawing.Point(320, 323);
            this.ServosComboBox.Name = "ServosComboBox";
            this.ServosComboBox.Size = new System.Drawing.Size(121, 21);
            this.ServosComboBox.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ServosComboBox);
            this.Controls.Add(this.Servo_activities_label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ServoSwing);
            this.Controls.Add(this.ServoPlus90);
            this.Controls.Add(this.ServoZero);
            this.Controls.Add(this.ServoMinus90);
            this.Controls.Add(this.SendCommand);
            this.Controls.Add(this.SenderTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RecievedDataBox);
            this.Controls.Add(this.Connect_to_Arduino);
            this.Controls.Add(this.Init_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Read_command_file);
            this.Controls.Add(this.NumOfPortsLabel);
            this.Controls.Add(this.NumOfPortsTextBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.OffButton);
            this.Controls.Add(this.OnButton);
            this.Controls.Add(this.PortBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox PortBox;
        private System.Windows.Forms.Button OnButton;
        private System.Windows.Forms.Button OffButton;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.TextBox NumOfPortsTextBox;
        private System.Windows.Forms.Label NumOfPortsLabel;
        private System.Windows.Forms.Button Read_command_file;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Init_button;
        private System.Windows.Forms.Button Connect_to_Arduino;
        private System.Windows.Forms.TextBox RecievedDataBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SenderTextBox;
        private System.Windows.Forms.Button SendCommand;
        private System.Windows.Forms.Button ServoMinus90;
        private System.Windows.Forms.Button ServoZero;
        private System.Windows.Forms.Button ServoPlus90;
        private System.Windows.Forms.Button ServoSwing;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Servo_activities_label;
        private System.Windows.Forms.ComboBox ServosComboBox;
    }
}

