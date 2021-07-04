
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
            this.OnButton.Location = new System.Drawing.Point(130, 109);
            this.OnButton.Name = "OnButton";
            this.OnButton.Size = new System.Drawing.Size(121, 23);
            this.OnButton.TabIndex = 1;
            this.OnButton.Text = "ON";
            this.OnButton.UseVisualStyleBackColor = true;
            this.OnButton.Click += new System.EventHandler(this.OnButton_Click);
            // 
            // OffButton
            // 
            this.OffButton.Location = new System.Drawing.Point(130, 150);
            this.OffButton.Name = "OffButton";
            this.OffButton.Size = new System.Drawing.Size(121, 23);
            this.OffButton.TabIndex = 2;
            this.OffButton.Text = "OFF";
            this.OffButton.UseVisualStyleBackColor = true;
            this.OffButton.Click += new System.EventHandler(this.OffButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(149, 234);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(104, 46);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // NumOfPortsTextBox
            // 
            this.NumOfPortsTextBox.Location = new System.Drawing.Point(130, 13);
            this.NumOfPortsTextBox.Name = "NumOfPortsTextBox";
            this.NumOfPortsTextBox.Size = new System.Drawing.Size(40, 20);
            this.NumOfPortsTextBox.TabIndex = 4;
            // 
            // NumOfPortsLabel
            // 
            this.NumOfPortsLabel.AutoSize = true;
            this.NumOfPortsLabel.Location = new System.Drawing.Point(44, 20);
            this.NumOfPortsLabel.Name = "NumOfPortsLabel";
            this.NumOfPortsLabel.Size = new System.Drawing.Size(67, 13);
            this.NumOfPortsLabel.TabIndex = 5;
            this.NumOfPortsLabel.Text = "Num of ports";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NumOfPortsLabel);
            this.Controls.Add(this.NumOfPortsTextBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.OffButton);
            this.Controls.Add(this.OnButton);
            this.Controls.Add(this.PortBox);
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
    }
}

