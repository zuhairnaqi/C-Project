namespace Library
{
    partial class SendEmail
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
            this.sending_email_data = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Body = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.sendingTo = new System.Windows.Forms.TextBox();
            this.Subject = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sending_email_data)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sending_email_data
            // 
            this.sending_email_data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sending_email_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sending_email_data.Location = new System.Drawing.Point(44, 72);
            this.sending_email_data.Name = "sending_email_data";
            this.sending_email_data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sending_email_data.Size = new System.Drawing.Size(711, 189);
            this.sending_email_data.TabIndex = 9;
            this.sending_email_data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Sending_Email_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(312, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 36);
            this.label1.TabIndex = 8;
            this.label1.Text = "Send Email";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Body);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.sendingTo);
            this.panel1.Controls.Add(this.Subject);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(44, 279);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 159);
            this.panel1.TabIndex = 10;
            // 
            // Body
            // 
            this.Body.Location = new System.Drawing.Point(371, 21);
            this.Body.Name = "Body";
            this.Body.Size = new System.Drawing.Size(203, 96);
            this.Body.TabIndex = 14;
            this.Body.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(617, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 48);
            this.button1.TabIndex = 13;
            this.button1.Text = "Send mail";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sendingTo
            // 
            this.sendingTo.Location = new System.Drawing.Point(103, 29);
            this.sendingTo.Name = "sendingTo";
            this.sendingTo.Size = new System.Drawing.Size(157, 20);
            this.sendingTo.TabIndex = 12;
            // 
            // Subject
            // 
            this.Subject.Location = new System.Drawing.Point(103, 72);
            this.Subject.Name = "Subject";
            this.Subject.Size = new System.Drawing.Size(157, 20);
            this.Subject.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "To :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(296, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Message :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Subject :";
            // 
            // SendEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sending_email_data);
            this.Controls.Add(this.label1);
            this.Name = "SendEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SendEmail";
            this.Load += new System.EventHandler(this.SendEmail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sending_email_data)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView sending_email_data;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox Body;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox sendingTo;
        private System.Windows.Forms.TextBox Subject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}