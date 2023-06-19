using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Project_uas
{
    
    public partial class Sign_Up : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        

        public Sign_Up()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (!this.textBoxEmail.Text.Contains('@') || !this.textBoxEmail.Text.Contains('.'))
            {
                MessageBox.Show("Please Enter A Valid Email", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBoxPassword.Text != textBoxPassword.Text)
            {
                MessageBox.Show("Password doesn't match!", "Error");
                return;
            }

            if (string.IsNullOrEmpty(textBoxName.Text) 
                || string.IsNullOrEmpty(textBoxEmail.Text) 
                || string.IsNullOrEmpty(textBoxPassword.Text) 
                || string.IsNullOrEmpty(comboBoxCategory.Text) )
            {
                MessageBox.Show("Please fill out all information!", "Error");
                return;
            }

            else
            {
                connection.Open();

                MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM dbhomecatering.tbcatering  WHERE Username = @UserName", connection),
                cmd2 = new MySqlCommand("SELECT * FROM dbhomecatering.tbcatering WHERE Email = @UserEmail", connection);


                cmd1.Parameters.AddWithValue("@UserName", textBoxName.Text);
                cmd2.Parameters.AddWithValue("@UserEmail", textBoxEmail.Text);

                bool userExists = false, mailExists = false;

                using (var dr1 = cmd1.ExecuteReader())
                    if (userExists = dr1.HasRows) MessageBox.Show("Username not available!");

                using (var dr2 = cmd2.ExecuteReader())
                    if (mailExists = dr2.HasRows) MessageBox.Show("Email not available!");


                if (!(userExists || mailExists))
                {

                    string iquery = "INSERT INTO dbhomecatering.tbcatering (`ID`,`Username`, `Email`,`Password`) VALUES (NULL, '" + textBoxName.Text + "',  '" + textBoxEmail.Text + "', '" + textBoxPassword.Text + "')";
                    MySqlCommand commandDatabase = new MySqlCommand(iquery, connection);
                    commandDatabase.CommandTimeout = 60;

                    try
                    {
                        MySqlDataReader myReader = commandDatabase.ExecuteReader();
                    }
                    catch (Exception ex)
                    {
                        // Show any error message.
                        MessageBox.Show(ex.Message);
                    }

                    MessageBox.Show("Account Successfully Created!");

                }

                connection.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        private void Sign_Up_Load(object sender, EventArgs e)
        {
            comboBoxCategory.Items.Add("pelanggan");
            comboBoxCategory.Items.Add("penjual");
        }
    }
}
