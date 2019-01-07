using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Library
{
    public partial class mdi_user : Form
    {
        private int childFormNumber = 0;
        
        public mdi_user()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
        private void addBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_book ab = new Add_book();
            ab.Show();
        }

        private void editBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edit_Book ed = new Edit_Book();
            ed.Show();
        }

        private void deleteBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete_book db = new Delete_book();
            db.Show();
        }

        private void addStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Student ad = new Add_Student();
            ad.Show();
        }

        private void editStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edit_Student es = new Edit_Student();
            es.Show();
        }

        private void deleteStudentToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Delete_Student ds = new Delete_Student();
            ds.Show();
        }

        private void toStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Issue_Book_ToStudent ib = new Issue_Book_ToStudent();
            ib.Show();
        }

        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Returns_book rb = new Returns_book();
            rb.Show();
        }

        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendEmail se = new SendEmail();
            se.Show();
        }

        private void mdi_user_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Add_book ab = new Add_book();
            ab.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Edit_Book ed = new Edit_Book();
            ed.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Delete_book db = new Delete_book();
            db.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Add_Student ad = new Add_Student();
            ad.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Edit_Student es = new Edit_Student();
            es.Show();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Delete_Student ds = new Delete_Student();
            ds.Show();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Issue_Book_ToStudent ib = new Issue_Book_ToStudent();
            ib.Show();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            Returns_book rb = new Returns_book();
            rb.Show();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            SendEmail se = new SendEmail();
            se.Show();
        }
    }
}
