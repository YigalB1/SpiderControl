
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
            this.SuspendLayout();
            // 
            // PortBox
            // 
            this.PortBox.FormattingEnabled = true;
            this.PortBox.Location = new System.Drawing.Point(195, 109);
            this.PortBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PortBox.Name = "PortBox";
            this.PortBox.Size = new System.Drawing.Size(180, 28);
            this.PortBox.TabIndex = 0;
            this.PortBox.SelectedIndexChanged += new System.EventHandler(this.PortBox_SelectedIndexChanged);
            // 
            // OnButton
            // 
            this.OnButton.Location = new System.Drawing.Point(195, 422);
            this.OnButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OnButton.Name = "OnButton";
            this.OnButton.Size = new System.Drawing.Size(182, 35);
            this.OnButton.TabIndex = 1;
            this.OnButton.Text = "ON";
            this.OnButton.UseVisualStyleBackColor = true;
            this.OnButton.Click += new System.EventHandler(this.OnButton_Click);
            // 
            // OffButton
            // 
            this.OffButton.Location = new System.Drawing.Point(195, 485);
            this.OffButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OffButton.Name = "OffButton";
            this.OffButton.Size = new System.Drawing.Size(182, 35);
            this.OffButton.TabIndex = 2;
            this.OffButton.Text = "OFF";
            this.OffButton.UseVisualStyleBackColor = true;
            this.OffButton.Click += new System.EventHandler(this.OffButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(861, 469);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(244, 158);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // NumOfPortsTextBox
            // 
            this.NumOfPortsTextBox.Location = new System.Drawing.Point(195, 20);
            this.NumOfPortsTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NumOfPortsTextBox.Name = "NumOfPortsTextBox";
            this.NumOfPortsTextBox.Size = new System.Drawing.Size(58, 26);
            this.NumOfPortsTextBox.TabIndex = 4;
            // 
            // NumOfPortsLabel
            // 
            this.NumOfPortsLabel.AutoSize = true;
            this.NumOfPortsLabel.Location = new System.Drawing.Point(66, 31);
            this.NumOfPortsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NumOfPortsLabel.Name = "NumOfPortsLabel";
            this.NumOfPortsLabel.Size = new System.Drawing.Size(100, 20);
            this.NumOfPortsLabel.TabIndex = 5;
            this.NumOfPortsLabel.Text = "Num of ports";
            this.NumOfPortsLabel.Click += new System.EventHandler(this.NumOfPortsLabel_Click);
            // 
            // Read_command_file
            // 
            this.Read_command_file.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Read_command_file.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.Read_command_file.Location = new System.Drawing.Point(193, 340);
            this.Read_command_file.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Read_command_file.Name = "Read_command_file";
            this.Read_command_file.Size = new System.Drawing.Size(182, 42);
            this.Read_command_file.TabIndex = 6;
            this.Read_command_file.Text = "Read Command File";
            this.Read_command_file.UseVisualStyleBackColor = false;
            this.Read_command_file.Click += new System.EventHandler(this.Read_command_file_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Selected port";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Init_button
            // 
            this.Init_button.Location = new System.Drawing.Point(199, 286);
            this.Init_button.Name = "Init_button";
            this.Init_button.Size = new System.Drawing.Size(176, 36);
            this.Init_button.TabIndex = 9;
            this.Init_button.Text = "Init";
            this.Init_button.UseVisualStyleBackColor = true;
            this.Init_button.Click += new System.EventHandler(this.Init_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.Init_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Read_command_file);
            this.Controls.Add(this.NumOfPortsLabel);
            this.Controls.Add(this.NumOfPortsTextBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.OffButton);
            this.Controls.Add(this.OnButton);
            this.Controls.Add(this.PortBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

