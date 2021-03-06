﻿using System;
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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        string connection_string = @"Data Source=DESKTOP-0E4IC3V\SQLEXPRESS;Initial Catalog=Public;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        private void cancel_Click(object sender, EventArgs e)
        {
            Sign_in sign_in = new Sign_in();
            DialogResult result;
            result = MessageBox.Show("Ви впевнений?", "Попередження", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                this.Close();
                sign_in.Show();
            }
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            password.PasswordChar = '*';
            rpassword.PasswordChar = '*';
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                MessageBox.Show("The Caps Lock is ON", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                password.Enabled = false;
                rpassword.Enabled = false;
            }
            else
            {
                password.Enabled = true;
                rpassword.Enabled = true;
            }
        }

        private void Registration_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void ok_Click(object sender, EventArgs e)
        {
            DialogResult result;
            int faculty_id = faculty.SelectedIndex + 1;
            int chair_id = chair.SelectedIndex + 1;
            int course = Convert.ToInt32(year.Value);
            if (name.Text == "" || login.Text == "" || faculty.Text == "" || chair.Text == "" || year.Text == ""||
                role.Text == "" || password.Text == "" || rpassword.Text == "")
            {
                MessageBox.Show("Обов'язково заповнити всі поля", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(password.Text != rpassword.Text)
            {
                MessageBox.Show("Повторний пароль є неправильним", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(connection_string))
                {
                    string query = "INSERT INTO Users VALUES(@username, @userlogin, @faculty_id, @chair_id, @user_year, @user_role, @user_password)";
                    using (SqlCommand queryInsertUser = new SqlCommand(query))
                    {
                        queryInsertUser.Connection = connection;
                        queryInsertUser.Parameters.Add("@username", SqlDbType.VarChar, 100).Value = name.Text;
                        queryInsertUser.Parameters.Add("@userlogin", SqlDbType.VarChar, 100).Value = login.Text;
                        queryInsertUser.Parameters.Add("@faculty_id", SqlDbType.Int).Value = faculty_id;
                        queryInsertUser.Parameters.Add("@chair_id", SqlDbType.Int).Value = chair_id;
                        queryInsertUser.Parameters.Add("@user_year", SqlDbType.Int).Value = course;
                        queryInsertUser.Parameters.Add("@user_role", SqlDbType.VarChar, 100).Value = role.Text;
                        queryInsertUser.Parameters.Add("@user_password", SqlDbType.VarChar, 100).Value = password.Text;
                        try
                        {
                            connection.Open();
                            queryInsertUser.ExecuteNonQuery();
                            result = MessageBox.Show("Успішно зареєстрував", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if(result == DialogResult.OK)
                            {
                                name.Text = "";
                                login.Text = "";
                                faculty.Text = "";
                                chair.Text = "";
                                year.Text = "";
                                role.Text = "";
                                password.Text = "";
                                rpassword.Text = "";
                            }
                        }
                        catch(SqlException ex)
                        {
                            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }    
            }
        }
    }
}
