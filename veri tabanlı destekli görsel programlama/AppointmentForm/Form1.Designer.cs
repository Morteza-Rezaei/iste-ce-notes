namespace AppointmentForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.patientNameTextBox = new System.Windows.Forms.TextBox();
            this.patientEmailTextBox = new System.Windows.Forms.TextBox();
            this.doctorNameTextBox = new System.Windows.Forms.TextBox();
            this.departmentComboBox = new System.Windows.Forms.ComboBox();
            this.SaveAppointmentButton = new System.Windows.Forms.Button();
            this.appointmentDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasta Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "E-posta :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Randevu Tarihi ve saati :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Doktor Adı :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(150, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Bölüm :";
            // 
            // patientNameTextBox
            // 
            this.patientNameTextBox.Location = new System.Drawing.Point(351, 88);
            this.patientNameTextBox.Name = "patientNameTextBox";
            this.patientNameTextBox.Size = new System.Drawing.Size(299, 22);
            this.patientNameTextBox.TabIndex = 5;
            // 
            // patientEmailTextBox
            // 
            this.patientEmailTextBox.Location = new System.Drawing.Point(351, 132);
            this.patientEmailTextBox.Name = "patientEmailTextBox";
            this.patientEmailTextBox.Size = new System.Drawing.Size(299, 22);
            this.patientEmailTextBox.TabIndex = 6;
            // 
            // doctorNameTextBox
            // 
            this.doctorNameTextBox.Location = new System.Drawing.Point(351, 220);
            this.doctorNameTextBox.Name = "doctorNameTextBox";
            this.doctorNameTextBox.Size = new System.Drawing.Size(299, 22);
            this.doctorNameTextBox.TabIndex = 7;
            // 
            // departmentComboBox
            // 
            this.departmentComboBox.FormattingEnabled = true;
            this.departmentComboBox.Items.AddRange(new object[] {
            "Kardiyoloji",
            "Nöroloji",
            "Ortopedi",
            "Pediatre"});
            this.departmentComboBox.Location = new System.Drawing.Point(351, 262);
            this.departmentComboBox.Name = "departmentComboBox";
            this.departmentComboBox.Size = new System.Drawing.Size(299, 24);
            this.departmentComboBox.TabIndex = 9;
            // 
            // SaveAppointmentButton
            // 
            this.SaveAppointmentButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.SaveAppointmentButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SaveAppointmentButton.Location = new System.Drawing.Point(255, 319);
            this.SaveAppointmentButton.Name = "SaveAppointmentButton";
            this.SaveAppointmentButton.Size = new System.Drawing.Size(290, 43);
            this.SaveAppointmentButton.TabIndex = 10;
            this.SaveAppointmentButton.Text = "Randevuyu Kaydet";
            this.SaveAppointmentButton.UseVisualStyleBackColor = false;
            this.SaveAppointmentButton.Click += new System.EventHandler(this.SaveAppointmentButton_Click);
            // 
            // appointmentDateTimePicker
            // 
            this.appointmentDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.appointmentDateTimePicker.Location = new System.Drawing.Point(351, 176);
            this.appointmentDateTimePicker.Name = "appointmentDateTimePicker";
            this.appointmentDateTimePicker.Size = new System.Drawing.Size(299, 22);
            this.appointmentDateTimePicker.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.appointmentDateTimePicker);
            this.Controls.Add(this.SaveAppointmentButton);
            this.Controls.Add(this.departmentComboBox);
            this.Controls.Add(this.doctorNameTextBox);
            this.Controls.Add(this.patientEmailTextBox);
            this.Controls.Add(this.patientNameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox patientNameTextBox;
        private System.Windows.Forms.TextBox patientEmailTextBox;
        private System.Windows.Forms.TextBox doctorNameTextBox;
        private System.Windows.Forms.ComboBox departmentComboBox;
        private System.Windows.Forms.Button SaveAppointmentButton;
        private System.Windows.Forms.DateTimePicker appointmentDateTimePicker;
    }
}

