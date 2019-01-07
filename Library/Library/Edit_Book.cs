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
    public partial class Edit_Book : Form
    {
        public Edit_Book()
        {
            InitializeComponent();
        }
        public int edit_line;
        public int removed_data;

        private void Edit_Book_Load(object sender, EventArgs e)
        {
            Display_Books();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel1.Visible = true;
            //Data in TextBoxes to edit things
            book_name.Text = Edit_Book_dataGridView.SelectedCells[0].Value.ToString();
            author_name.Text = Edit_Book_dataGridView.SelectedCells[1].Value.ToString();
            publication_name.Text = Edit_Book_dataGridView.SelectedCells[2].Value.ToString();
            quantity.Text = Edit_Book_dataGridView.SelectedCells[3].Value.ToString();
            dateTimePicker1.Text = Edit_Book_dataGridView.SelectedCells[4].Value.ToString();
            price.Text = Edit_Book_dataGridView.SelectedCells[5].Value.ToString();
            
            edit_line = Edit_Book_dataGridView.CurrentCell.RowIndex + 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //edit_line++;
            //int line_to_edit = 2;
            string lineToWrite = null;
            bool successfully_edit = false;
            lineToWrite = book_name.Text + "?" + author_name.Text + "!" + publication_name.Text + "@" + quantity.Text + "#" + dateTimePicker1.Text + "$" + price.Text + ".";

            string[] lines = File.ReadAllLines("Book_list");
            // Write the new file over the old file.
            using (StreamWriter writer = new StreamWriter("Book_list"))
            {
                for (int currentLine = 1; currentLine <= lines.Length; ++currentLine)
                {
                    if (currentLine == edit_line)
                    {
                        writer.WriteLine(lineToWrite);
                        MessageBox.Show("Book successfully edited!");
                        panel1.Visible = false;
                        successfully_edit = true;
                    }
                    else
                    {
                        writer.WriteLine(lines[currentLine - 1]);
                    }
                }
            }
            if (successfully_edit)
            {
                Display_Books();
            }
        }
        public void Display_Books()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Book Name", typeof(string));
            dt.Columns.Add("Author Name", typeof(string));
            dt.Columns.Add("Publication Name", typeof(string));
            dt.Columns.Add("Quantity", typeof(string));
            dt.Columns.Add("Added Date", typeof(string));
            dt.Columns.Add("Price", typeof(string));

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
                    string added_date = file.Substring(forthOper + 1, fiveOper - forthOper - 1);
                    string price = file.Substring(fiveOper + 1, sixthOper - fiveOper - 1);
                    DataRow dr = dt.NewRow();
                    dr["Book Name"] = name;
                    dr["Author Name"] = author_name;
                    dr["Publication Name"] = publication_name;
                    dr["Quantity"] = quantity;
                    dr["Added Date"] = added_date;
                    dr["Price"] = price;

                    dt.Rows.Add(dr);
                }
                else
                {
                    break;
                }
            }
            Edit_Book_dataGridView.DataSource = dt;
            sr.Close();
        }
    }
}
