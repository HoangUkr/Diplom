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
    public partial class Employee : Form
    {
        public string username;
        public string userlogin;
        public Employee(string username, string userlogin)
        {
            InitializeComponent();
            this.username = username;
            this.userlogin = userlogin;
        }

        private void проАвтораToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void upload_image_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                avatar.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            name.Text = this.username;
            login.Text = this.userlogin;
        }

        private void Employee_FormClosed(object sender, FormClosedEventArgs e)
        {
            Sign_in signin = new Sign_in();
            signin.Show();
        }

        private void програмОбмінуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exchange exchange = new Exchange(label1.Text,"",0);
            exchange.Show();
        }
    }
}
