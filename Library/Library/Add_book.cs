using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Library
{
    public partial class Add_book : Form
    {
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C: \Users\Perfect\Documents\library Sql.mdf';Integrated Security=True;Connect Timeout=30");
        public Add_book()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //con.Open();
            //SqlCommand cmd = con.CreateCommand();
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "insert into add_book values('"+ textBox1.Text +"','" + textBox2.Text + "','" + textBox3.Text + "'," + textBox4.Text + ",'" + dateTimePicker1.Text + "'," + textBox6.Text + ")";
            //cmd.ExecuteNonQuery();
            if(textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && dateTimePicker1.Text != "" && textBox6.Text != "")
            {
                StreamWriter sw = new StreamWriter("Book_list",true);
                sw.WriteLine("{0}?{1}!{2}@{3}#{4}${5}.", textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, dateTimePicker1.Text, textBox6.Text);
                //con.Close();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox6.Text = "";
                MessageBox.Show("Book successfully saved");
                sw.Close();
            }
            else
            {
                MessageBox.Show("Please fill all the fields");
            }
        }
    }
}
