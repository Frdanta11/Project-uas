using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Project_uas
{
    public partial class Login : Form
    {
        MySqlConnection connection= new MySqlConnection("datasource=localhost;port=3306;Username=root;password=");
        MySqlCommand command;
        MySqlDataReader mdr;
        public Login()
        {
            InitializeComponent();
        }

        private void linkLabelSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sign_Up sign_Up = new Sign_Up();
            sign_Up.ShowDialog();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxUsername.Text) || string.IsNullOrEmpty(textBoxPassword.Text))
            {
                MessageBox.Show("Please input Username and Password", "Error");
            }

            else
            {
                connection.Open();
                string selectQuery = "SELECT * FROM dbhomecatering.tbcatering WHERE Username = @Username AND Password = @Password ";
                MySqlCommand command = 
                
                
                new MySqlCommand(selectQuery, connection);
                command.Parameters.AddWithValue("@Username", textBoxUsername.Text);

                command.Parameters.AddWithValue("@Password", textBoxPassword.Text);

                mdr = command.ExecuteReader();
                if (mdr.Read())
                {
                    string MyConnection2 = "datasource=localhost;port=3306;Username=root;password=";
                    string Query = "update dbhomecatering.tbcatering  where Username='" + this.textBoxUsername.Text + "';";
                    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MySqlDataReader MyReader2;
                    MyConn2.Open();
                    
                    MyConn2.Close();

                    MessageBox.Show("Login Successful!");
                    this.Hide();
                    beranda beranda= new beranda();
                    beranda.ShowDialog();

                }
                else
                {

                    MessageBox.Show("Incorrect Login Information! Try again.");
                }

                connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            beranda beranda = new beranda();
            beranda.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
