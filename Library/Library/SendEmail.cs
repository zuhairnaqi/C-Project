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
using System.Net;
using System.Net.Mail;

namespace Library
{
    public partial class SendEmail : Form
    {
        public SendEmail()
        {
            InitializeComponent();
        }
        public int sendingPersonIndex;
        private void SendEmail_Load(object sender, EventArgs e)
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
            sending_email_data.DataSource = dt;
            sr.Close();
        }

        private void Sending_Email_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel1.Visible = true;
            sendingTo.Text = sending_email_data.SelectedCells[4].Value.ToString();
            sendingPersonIndex = sending_email_data.CurrentCell.RowIndex + 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();

                message.From = new MailAddress("admin_gmail_ID");
                message.To.Add(new MailAddress(sendingTo.Text));
                message.Subject = Subject.Text;
                message.Body = Body.Text;

                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("admin_gmail_ID", "admin_password");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
                MessageBox.Show("Your email has been successfully delivered");
                panel1.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("err: " + ex.Message);
            }
        }
    }
}
