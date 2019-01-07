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
    public partial class Issue_Book_ToStudent : Form
    {
        public Issue_Book_ToStudent()
        {
            InitializeComponent();
        }
        public int selected_student;

        private void Issue_Book_ToStudent_Load(object sender, EventArgs e)
        {
            Display_Books();
            Display_Students();
        }
        public void Display_Books()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Book Name", typeof(string));
            dt.Columns.Add("Author Name", typeof(string));

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
                    DataRow dr = dt.NewRow();
                    dr["Book Name"] = name;
                    dr["Author Name"] = author_name;

                    dt.Rows.Add(dr);
                }
                else
                {
                    break;
                }
            }
            Books_data.DataSource = dt;
            sr.Close();
        }
        public void Display_Students()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Student Name", typeof(string));
            dt.Columns.Add("Department", typeof(string));

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
                    string department = file.Substring(secondOper + 1, thirdOper - secondOper - 1);
                    DataRow dr = dt.NewRow();
                    dr["Student Name"] = std_name;
                    dr["Department"] = department;

                    dt.Rows.Add(dr);
                }
                else
                {
                    break;
                }
            }
            Students_data.DataSource = dt;
            sr.Close();
        }

        private void Students_data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Data in TextBoxes to edit things
            std_name.Text = Students_data.SelectedCells[0].Value.ToString();
            std_depart.Text = Students_data.SelectedCells[1].Value.ToString();

            //selected_student = Students_data.CurrentCell.RowIndex + 1;
        }

        private void Book_data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Data in TextBoxes to edit things
            book_name.Text = Books_data.SelectedCells[0].Value.ToString();
            author_name.Text = Books_data.SelectedCells[1].Value.ToString();

            //selected_student = Students_data.CurrentCell.RowIndex + 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (std_name.Text != "" && std_depart.Text != "" && book_name.Text != "" && author_name.Text != "" && std_gmail.Text != "" && issue_book_dateTimePicker.Text != "")
            {
                bool validate_email = CheckEmailAddress(std_gmail.Text);

                if (validate_email)
                {
                    StreamWriter sw = new StreamWriter("Issued_book_list", true);
                    sw.WriteLine("{0}?{1}!{2}@{3}#{4}${5}%", std_name.Text, std_depart.Text, book_name.Text, author_name.Text, std_gmail.Text, issue_book_dateTimePicker.Text);
                    //con.Close();
                    std_name.Text = "";
                    std_depart.Text = "";
                    book_name.Text = "";
                    author_name.Text = "";
                    std_gmail.Text = "";
                    MessageBox.Show("Issued Book successfully saved");
                    sw.Close();
                }
                else
                {
                    MessageBox.Show("Please insert a valid email");
                }
            }
            else
            {
                MessageBox.Show("Please fill all the fields");
            }
        }
        public bool CheckEmailAddress(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }

        }

        private void Books_data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
