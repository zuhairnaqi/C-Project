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
    public partial class Delete_Student : Form
    {
        public Delete_Student()
        {
            InitializeComponent();
        }
        public int delete_line;

        private void Delete_Student_Load(object sender, EventArgs e)
        {
            Display_Students();
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
                if (file != null  && file != "")
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
            remove_std_dataGridView.DataSource = dt;
            sr.Close();
        }

        private void Remove_Std_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Delete_btn.Visible = true;
            delete_line = remove_std_dataGridView.CurrentCell.RowIndex + 1;
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            bool successfully_delete = false;
            string[] lines = File.ReadAllLines("Student_list");
            // Write the new file over the old file.
            using (StreamWriter writer = new StreamWriter("Student_list"))
            {
                for (int currentLine = 1; currentLine <= lines.Length; ++currentLine)
                {
                    if (currentLine == delete_line)
                    {
                        writer.Write("");
                        MessageBox.Show("Student successfully Deleted!");
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
                Display_Students();
            }
        }
    }
}
