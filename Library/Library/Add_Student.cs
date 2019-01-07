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
    public partial class Add_Student : Form
    {
        public Add_Student()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (std_name.Text != "" && std_class.Text != "" && std_depart.Text != "" && std_phone.Text != "" && std_dateTimePicker1.Text != "" && std_address.Text != "")
            {
                StreamWriter sw = new StreamWriter("Student_list", true);
                sw.WriteLine("{0}?{1}!{2}@{3}#{4}${5}.", std_name.Text, std_class.Text, std_depart.Text, std_phone.Text, std_address.Text, std_dateTimePicker1.Text);
                //con.Close();
                std_name.Text = "";
                std_class.Text = "";
                std_depart.Text = "";
                std_phone.Text = "";
                std_address.Text = "";
                MessageBox.Show("Student successfully Added");
                sw.Close();
            }
            else
            {
                MessageBox.Show("Please fill all the fields");
            }
        }
    }
}
