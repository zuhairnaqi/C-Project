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
    public partial class Edit_Student : Form
    {
        public Edit_Student()
        {
            InitializeComponent();
        }

        public int edit_line;

        private void Edit_Student_Load(object sender, EventArgs e)
        {
            Display_Students();
        }

        private void Edit_Std_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Std_panel.Visible = true;
            //Data in TextBoxes to edit things
            std_name.Text = Edit_std_dataGridView1.SelectedCells[0].Value.ToString();
            std_class.Text = Edit_std_dataGridView1.SelectedCells[1].Value.ToString();
            std_depart.Text = Edit_std_dataGridView1.SelectedCells[2].Value.ToString();
            std_phone.Text = Edit_std_dataGridView1.SelectedCells[3].Value.ToString();
            std_address.Text = Edit_std_dataGridView1.SelectedCells[4].Value.ToString();
            std_dateTimePicker.Text = Edit_std_dataGridView1.SelectedCells[5].Value.ToString();

            edit_line = Edit_std_dataGridView1.CurrentCell.RowIndex + 1;
        }
        public void Display_Students()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Student Name", typeof(string));
            dt.Columns.Add("Class", typeof(string));
            dt.Columns.Add("Department", typeof(string));
            dt.Columns.Add("Phone #", typeof(string));
            dt.Columns.Add("Address", typeof(string));
            dt.Columns.Add("Added Date", typeof(string));

            StreamReader sr = new StreamReader("Student_list");
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
                    string std_name = file.Substring(0, firstOper);
                    string std_class = file.Substring(firstOper + 1, secondOper - firstOper - 1);
                    string department = file.Substring(secondOper + 1, thirdOper - secondOper - 1);
                    string phone_num = file.Substring(thirdOper + 1, forthOper - thirdOper - 1);
                    string address = file.Substring(forthOper + 1, fiveOper - forthOper - 1);
                    string added_date = file.Substring(fiveOper + 1, sixthOper - fiveOper - 1);
                    DataRow dr = dt.NewRow();
                    dr["Student Name"] = std_name;
                    dr["Class"] = std_class;
                    dr["Department"] = department;
                    dr["Phone #"] = phone_num;
                    dr["Address"] = address;
                    dr["Added Date"] = added_date;

                    dt.Rows.Add(dr);
                }
                else
                {
                    break;
                }
            }
            Edit_std_dataGridView1.DataSource = dt;
            sr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string lineToWrite = null;
            bool successfully_edit = false;
            lineToWrite = std_name.Text + "?" + std_class.Text + "!" + std_depart.Text + "@" + std_phone.Text + "#" + std_address.Text + "$" + std_dateTimePicker.Text + ".";

            string[] lines = File.ReadAllLines("Student_list");
            // Write the new file over the old file.
            using (StreamWriter writer = new StreamWriter("Student_list"))
            {
                for (int currentLine = 1; currentLine <= lines.Length; ++currentLine)
                {
                    if (currentLine == edit_line)
                    {
                        writer.WriteLine(lineToWrite);
                        MessageBox.Show("Student successfully edited!");
                        Std_panel.Visible = false;
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
                Display_Students();
            }
        }
    }
}
