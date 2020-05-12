using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_v2
{
    public partial class Student : Form
    {
        public string username;
        public string userfaculty;
        public string userlogin;
        public string user_year;
        public Student(string username, string userfaculty, string userlogin, string user_year)
        {
            InitializeComponent();
            this.username = username;
            this.userfaculty = userfaculty;
            this.userlogin = userlogin;
            this.user_year = user_year;
        }

        private void проАвторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void upload_image_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                avatar.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        private void Student_FormClosed(object sender, FormClosedEventArgs e)
        {
            Sign_in signin = new Sign_in();
            signin.Show();
        }

        private void Student_Load(object sender, EventArgs e)
        {
            
            name.Text = this.username;
            faculty.Text = this.userfaculty;
            login.Text = this.userlogin;
            year.Text = this.user_year;
        }

        private void програмОбмінуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exchange exchange = new Exchange(label1.Text,faculty.Text, Convert.ToInt32(year.Text));
            exchange.Show();
        }

        private void подачаДокументівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Apply_Doc application = new Apply_Doc();
            application.Show();
        }

        private void документиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Document document = new Document();
            document.Show();
        }
    }
}
