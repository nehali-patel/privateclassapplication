using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace private_class_application
{
    public partial class NewAccount : Form
    {
        public NewAccount()
        {
            InitializeComponent();
        }
        String username = "", pass = "";

        SqlConnection sq = new SqlConnection(Properties.Settings.Default.con);
        private void Save_Click(object sender, EventArgs e)
        {
            if (Pass.Text.Length < 6)
            {
                MessageBox.Show("Password should be atleast 6 characters long");
            }
            else if (Pass .Text == "")
            {
                MessageBox.Show("Enter password");
            }
            else
            {
                sq.Open();
                SqlCommand sc = new SqlCommand("INSERT INTO NamePassword (LoginName, Password, Answer) VALUES ('" + User.Text + "','" + Pass.Text + "','" + Answer.Text + "')", sq);
                sc.ExecuteNonQuery();
                sq.Close();
                MessageBox.Show("Account successfully stored");

                username = User.Text;
                pass = Pass.Text;
                string answer1 = Answer.Text;
                if (Password.Text == Confirmpass.Text)
                {
                    MessageBox.Show("Password Confirmed");
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();

        }

        private void Answer_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            login l = new login();
            l.Show();
            this.Hide();
        }
    }
}
