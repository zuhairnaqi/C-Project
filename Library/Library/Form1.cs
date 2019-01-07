using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Library
{
	public partial class Form1 : Form
	{
        public Form1()
		{
			InitializeComponent();
		}

        private void button1_Click(object sender, EventArgs e)
        {
            LoginVerification L = new LoginVerification(textBox1.Text,textBox2.Text);
            L.Verified();
            if (L.confirmLogin)
            {
                this.Hide();
                mdi_user mu = new mdi_user();
                mu.Show();
            }
        }
    }
    class LoginVerification
    {
        string email;
        string password;
        public bool confirmLogin;
        public LoginVerification(string email,string pass)
        {
            this.email = email;
            password = pass;
        }
        public void Verified()
        {
            if(email == "admin" && password == "123456")
            {
                MessageBox.Show("Login confirmed");
                confirmLogin = true;
            }
            else
            {
                MessageBox.Show("User not found");
                confirmLogin = false;
            }
        }
    }
}
