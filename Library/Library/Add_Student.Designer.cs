namespace Library
{
    partial class Add_Student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Student));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.std_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.std_class = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.std_depart = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.std_phone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.std_address = new System.Windows.Forms.TextBox();
            this.std_dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Std Black", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Student Form";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Cooper Std Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(319, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // std_name
            // 
            this.std_name.Location = new System.Drawing.Point(345, 102);
            this.std_name.Name = "std_name";
            this.std_name.Size = new System.Drawing.Size(206, 20);
            this.std_name.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(205, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(203, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = " Class :";
            // 
            // std_class
            // 
            this.std_class.Location = new System.Drawing.Point(345, 141);
            this.std_class.Name = "std_class";
            this.std_class.Size = new System.Drawing.Size(206, 20);
            this.std_class.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(204, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Department :";
            // 
            // std_depart
            // 
            this.std_depart.Location = new System.Drawing.Point(345, 178);
            this.std_depart.Name = "std_depart";
            this.std_depart.Size = new System.Drawing.Size(206, 20);
            this.std_depart.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(204, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Phone # :";
            // 
            // std_phone
            // 
            this.std_phone.Location = new System.Drawing.Point(345, 218);
            this.std_phone.Name = "std_phone";
            this.std_phone.Size = new System.Drawing.Size(206, 20);
            this.std_phone.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(204, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "Address :";
            // 
            // std_address
            // 
            this.std_address.Location = new System.Drawing.Point(345, 256);
            this.std_address.Name = "std_address";
            this.std_address.Size = new System.Drawing.Size(206, 20);
            this.std_address.TabIndex = 2;
            // 
            // std_dateTimePicker1
            // 
            this.std_dateTimePicker1.Location = new System.Drawing.Point(345, 296);
            this.std_dateTimePicker1.Name = "std_dateTimePicker1";
            this.std_dateTimePicker1.Size = new System.Drawing.Size(206, 20);
            this.std_dateTimePicker1.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(205, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 22);
            this.label7.TabIndex = 5;
            this.label7.Text = "Date :";
            // 
            // Add_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(747, 450);
            this.Controls.Add(this.std_dateTimePicker1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.std_address);
            this.Controls.Add(this.std_phone);
            this.Controls.Add(this.std_depart);
            this.Controls.Add(this.std_class);
            this.Controls.Add(this.std_name);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Add_Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox std_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox std_class;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox std_depart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox std_phone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox std_address;
        private System.Windows.Forms.DateTimePicker std_dateTimePicker1;
        private System.Windows.Forms.Label label7;
    }
}