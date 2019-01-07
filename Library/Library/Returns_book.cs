using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Library
{
    public partial class Returns_book : Form
    {
        public Returns_book()
        {
            InitializeComponent();
        }
        public int delete_line;

        private void Returns_book_Load(object sender, EventArgs e)
        {
            DisplayIssuedBookStudents();
        }
        public void DisplayIssuedBookStudents()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Student Name", typeof(string));
            dt.Columns.Add("Department", typeof(string));
            dt.Columns.Add("Book Name", typeof(string));
            dt.Columns.Add("Author Name", typeof(string));
            dt.Columns.Add("Student Gmail", typeof(string));
            dt.Columns.Add("Added Date", typeof(string));

            StreamReader sr = new StreamReader("Issued_book_list");
            string file;
            while (true)
            {
                file = sr.ReadLine();
                if (file != null && file != "")
                {
                    int firstOper = file.IndexOf("?");
                    int secondOper = file.IndexOf("!");
                    int thirdOper = file.IndexOf("@");
                    int forthOper = file.IndexOf("#");
                    int fiveOper = file.IndexOf("$");
                    int sixthOper = file.IndexOf("%");
                    string std_name = file.Substring(0, firstOper);
                    string std_class = file.Substring(firstOper + 1, secondOper - firstOper - 1);
                    string department = file.Substring(secondOper + 1, thirdOper - secondOper - 1);
                    string phone_num = file.Substring(thirdOper + 1, forthOper - thirdOper - 1);
                    string address = file.Substring(forthOper + 1, fiveOper - forthOper - 1);
                    string add_date = file.Substring(fiveOper + 1, sixthOper - fiveOper - 1);
                    DataRow dr = dt.NewRow();
                    dr["Student Name"] = std_name;
                    dr["Department"] = department;
                    dr["Book Name"] = std_class;
                    dr["Author Name"] = phone_num;
                    dr["Student Gmail"] = address;
                    dr["Added Date"] = add_date;

                    dt.Rows.Add(dr);
                }
                else
                {
                    break;
                }
            }
            return_book_data.DataSource = dt;
            sr.Close();
        }

        private void ReturnBookCellClick(object sender, DataGridViewCellEventArgs e)
        {
            Return_btn.Visible = true;
            delete_line = return_book_data.CurrentCell.RowIndex + 1;
        }

        private void Return_btn_Click(object sender, EventArgs e)
        {
            bool successfully_delete = false;
            string[] lines = File.ReadAllLines("Issued_book_list");
            // Write the new file over the old file.
            using (StreamWriter writer = new StreamWriter("Issued_book_list"))
            {
                for (int currentLine = 1; currentLine <= lines.Length; ++currentLine)
                {
                    if (currentLine == delete_line)
                    {
                        writer.Write("");
                        MessageBox.Show("Student Name successfully Deleted!");
                        Return_btn.Visible = false;
                        successfully_delete = true;
                    }
                    else
                    {
                        writer.WriteLine(lines[currentLine - 1]);
                    }
                }
            }
            if (successfully_delete)
            {
                DisplayIssuedBookStudents();
            }
        }
    }
}
