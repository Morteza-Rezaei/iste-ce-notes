namespace ReservationForm
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
            this.customerNameTb = new System.Windows.Forms.TextBox();
            this.checkInDateTp = new System.Windows.Forms.DateTimePicker();
            this.CheckOutDateTp = new System.Windows.Forms.DateTimePicker();
            this.saveBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.emailTb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // customerNameTb
            // 
            this.customerNameTb.Location = new System.Drawing.Point(341, 129);
            this.customerNameTb.Name = "customerNameTb";
            this.customerNameTb.Size = new System.Drawing.Size(243, 22);
            this.customerNameTb.TabIndex = 0;
            // 
            // checkInDateTp
            // 
            this.checkInDateTp.Location = new System.Drawing.Point(341, 197);
            this.checkInDateTp.Name = "checkInDateTp";
            this.checkInDateTp.Size = new System.Drawing.Size(243, 22);
            this.checkInDateTp.TabIndex = 2;
            // 
            // CheckOutDateTp
            // 
            this.CheckOutDateTp.Location = new System.Drawing.Point(341, 231);
            this.CheckOutDateTp.Name = "CheckOutDateTp";
            this.CheckOutDateTp.Size = new System.Drawing.Size(243, 22);
            this.CheckOutDateTp.TabIndex = 3;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.saveBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.saveBtn.Location = new System.Drawing.Point(218, 282);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(364, 40);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "Kaydet";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "E-posta :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kullanıcı Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Giriş Tarihi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Çıkış Tarihi :";
            // 
            // emailTb
            // 
            this.emailTb.Location = new System.Drawing.Point(341, 163);
            this.emailTb.Name = "emailTb";
            this.emailTb.Size = new System.Drawing.Size(243, 22);
            this.emailTb.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.emailTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.CheckOutDateTp);
            this.Controls.Add(this.checkInDateTp);
            this.Controls.Add(this.customerNameTb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox customerNameTb;
        private System.Windows.Forms.DateTimePicker checkInDateTp;
        private System.Windows.Forms.DateTimePicker CheckOutDateTp;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox emailTb;
    }
}

