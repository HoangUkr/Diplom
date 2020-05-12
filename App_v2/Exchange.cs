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

namespace App_v2
{
    public partial class Exchange : Form
    {
        string role;
        string faculty;
        int course;
        static string connection_string = @"Data Source=DESKTOP-0E4IC3V\SQLEXPRESS;Initial Catalog=Public;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection connection = new SqlConnection(connection_string);
        public Exchange(string role, string faculty, int course)
        {
            InitializeComponent();
            this.role = role;
            this.faculty = faculty;
            this.course = course;
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void проАвтораToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }
        private void Exchange_Load(object sender, EventArgs e)
        {
            string query = "select Exchange.id, Exchange.program, Exchange.country, Faculty.faculty_name, Exchange.program_year" +
                            " from Exchange" +
                            " inner join Faculty" +
                            " on Exchange.faculty_id = Faculty.id";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            exchange_program.DataSource = dt;
            connection.Close();
        }

        private void category_CheckedChanged(object sender, EventArgs e)
        {
            if (category.Checked)
            {
                string query = "select Exchange.id, Exchange.program, Exchange.country, Faculty.faculty_name, Exchange.program_year" +
                            " from Exchange" +
                            " inner join Faculty" +
                            " on Exchange.faculty_id = Faculty.id " + 
                            "where faculty_name = '"+faculty+"'";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);
                exchange_program.DataSource = dt;
                connection.Close();
            }
        }
    }
}
