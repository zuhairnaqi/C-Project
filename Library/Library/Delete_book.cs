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
    public partial class Delete_book : Form
    {
        public Delete_book()
        {
            InitializeComponent();
        }
        public int delete_line;

        private void Delete_book_Load(object sender, EventArgs e)
        {
            Display_Book();
        }
        public void Display_Book()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Book Name", typeof(string));
            dt.Columns.Add("Author Name", typeof(string));
            dt.Columns.Add("Publication Name", typeof(string));
            dt.Columns.Add("Quantity", typeof(string));
            dt.Columns.Add("Price", typeof(string));
            dt.Columns.Add("Added Date", typeof(string));

            StreamReader sr = new StreamReader("Book_list");
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
                    int sixthOper = file.IndexOf(".");
                    string name = file.Substring(0, firstOper);
                    string author_name = file.Substring(firstOper + 1, secondOper - firstOper - 1);
                    string publication_name = file.Substring(secondOper + 1, thirdOper - secondOper - 1);
                    string quantity = file.Substring(thirdOper + 1, forthOper - thirdOper - 1);
                    string price = file.Substring(forthOper + 1, fiveOper - forthOper - 1);
                    string added_date = file.Substring(fiveOper + 1, sixthOper - fiveOper - 1);
                    //string price = "400";
                    //string added_date = "wed";
                    DataRow dr = dt.NewRow();
                    dr["Book Name"] = name;
                    dr["Author Name"] = author_name;
                    dr["Publication Name"] = publication_name;
                    dr["Quantity"] = quantity;
                    dr["Price"] = price;
                    dr["Added Date"] = added_date;

                    dt.Rows.Add(dr);
                }
                else
                {
                    break;
                }
            }
            dataGridView1.DataSource = dt;
            sr.Close();
        }

        private void Delete_book_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Delete_btn.Visible = true;
            delete_line = dataGridView1.CurrentCell.RowIndex + 1;
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            bool successfully_delete = false;
            string[] lines = File.ReadAllLines("Book_list");
            // Write the new file over the old file.
            using (StreamWriter writer = new StreamWriter("Book_list"))
            {
                for (int currentLine = 1; currentLine <= lines.Length; ++currentLine)
                {
                    if (currentLine == delete_line)
                    {
                        writer.Write("");
                        MessageBox.Show("Book successfully Deleted!");
                        Delete_btn.Visible = false;
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
                Display_Book();
            }
        }
    }
}
