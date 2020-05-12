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
    public partial class Sign_in : Form
    {
        string connection_string = @"Data Source=DESKTOP-0E4IC3V\SQLEXPRESS;Initial Catalog=Public;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public Sign_in()
        {
            InitializeComponent();
        }

        private void createAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            this.Hide();
        }

        private void Sign_in_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void entry_Click(object sender, EventArgs e)
        {
            
            if(username.Text == "")
            {
                MessageBox.Show("Немає логін","Попередження",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                username.Focus();
                return;
            }            
            if(password.Text == "")
            {
                MessageBox.Show("Немає пароль", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                password.Focus();
                return;
            }
            try
            {
                SqlConnection connection = new SqlConnection(connection_string);
                SqlCommand sqlCommand = new SqlCommand("select Users.username, Users.userlogin, Users.user_year, Users.user_role, Faculty.faculty_name from Users " +
                                                         "inner join Faculty on Users.faculty_id = Faculty.id " +
                                                         "WHERE userlogin = @login AND user_password = @password", connection);
                SqlParameter uName = new SqlParameter("@login", SqlDbType.VarChar);
                SqlParameter uPassword = new SqlParameter("@password", SqlDbType.VarChar);
                uName.Value = username.Text;
                uPassword.Value = password.Text;

                sqlCommand.Parameters.Add(uName);
                sqlCommand.Parameters.Add(uPassword);

                sqlCommand.Connection.Open();

                string username1;
                string userfaculty;
                string userlogin;
                string user_year;

                SqlDataReader myReader = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);
                if(myReader.Read() == true)
                {
                    if (myReader["user_role"].ToString() == "Студент")
                    {
                        username1 = myReader["username"].ToString();
                        userfaculty = myReader["faculty_name"].ToString();
                        userlogin = myReader["userlogin"].ToString();
                        user_year = myReader["user_year"].ToString();
                        Student student = new Student(username1, userfaculty, userlogin, user_year);
                        student.Show();
                        
                        this.Hide();
                    }
                    if (myReader["user_role"].ToString() == "Координатор")
                    {
                        username1 = myReader["username"].ToString();
                        userfaculty = myReader["faculty_name"].ToString();
                        userlogin = myReader["userlogin"].ToString();
                        Coordinator coordinator = new Coordinator(username1, userfaculty, userlogin);
                        coordinator.Show();
                        
                        this.Hide();
                    }
                    if (myReader["user_role"].ToString() == "Працівник відділу")
                    {
                        username1 = myReader["username"].ToString();
                        userlogin = myReader["userlogin"].ToString();
                        Employee employee = new Employee(username1, userlogin);
                        employee.Show();
                        
                        this.Hide();
                    }
                    if (myReader["user_role"].ToString() == "Завідувач факультету/кафедри")
                    {
                        username1 = myReader["username"].ToString();
                        userfaculty = myReader["faculty_name"].ToString();
                        userlogin = myReader["userlogin"].ToString();
                        Head head = new Head(username1, userfaculty, userlogin);
                        head.Show();
                        
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Аккаунт не існує", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    username.Clear();
                    password.Clear();
                }
                if(connection.State == ConnectionState.Open)
                {
                    connection.Dispose();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Sign_in_Load(object sender, EventArgs e)
        {
            password.PasswordChar = '*';
        }

        private void Sign_in_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
