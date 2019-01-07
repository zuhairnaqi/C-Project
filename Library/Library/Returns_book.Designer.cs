namespace Library
{
    partial class Returns_book
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
            this.label2 = new System.Windows.Forms.Label();
            this.Return_btn = new System.Windows.Forms.Button();
            this.return_book_data = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.return_book_data)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(61, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(382, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Select the list and press the return button to remove the student from issued lis" +
    "t.";
            // 
            // Return_btn
            // 
            this.Return_btn.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Return_btn.Location = new System.Drawing.Point(333, 322);
            this.Return_btn.Name = "Return_btn";
            this.Return_btn.Size = new System.Drawing.Size(103, 36);
            this.Return_btn.TabIndex = 6;
            this.Return_btn.Text = "Returns";
            this.Return_btn.UseVisualStyleBackColor = true;
            this.Return_btn.Visible = false;
            this.Return_btn.Click += new System.EventHandler(this.Return_btn_Click);
            // 
            // return_book_data
            // 
            this.return_book_data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.return_book_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.return_book_data.Location = new System.Drawing.Point(60, 108);
            this.return_book_data.Name = "return_book_data";
            this.return_book_data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.return_book_data.Size = new System.Drawing.Size(711, 189);
            this.return_book_data.TabIndex = 5;
            this.return_book_data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ReturnBookCellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(283, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Return Book";
            // 
            // Returns_book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(816, 452);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Return_btn);
            this.Controls.Add(this.return_book_data);
            this.Controls.Add(this.label1);
            this.Name = "Returns_book";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Returns_book";
            this.Load += new System.EventHandler(this.Returns_book_Load);
            ((System.ComponentModel.ISupportInitialize)(this.return_book_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Return_btn;
        private System.Windows.Forms.DataGridView return_book_data;
        private System.Windows.Forms.Label label1;
    }
}