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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        SqlConnection sq = new SqlConnection(Properties.Settings.Default.con);
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            SqlDataReader sdr = null;
            sq.Open();
            SqlCommand sc2 = new SqlCommand("SELECT  LoginName, Password FROM  NamePassword ", sq);
            sdr = sc2.ExecuteReader();
            string username = txtID.Text;
            string pass = txtpass.Text;

            while (sdr.Read())
            {
              
if (username == sdr["LoginName"].ToString() && pass == sdr["Password"].ToString())
                {
                    MessageBox.Show("Login successfully");
                    this.Hide();
                    Login1 l1 = new Login1();
                    l1.Show();
                   
                }
//else 
//{
 //MessageBox.Show("Login Failed");
//}
            }
sdr.Close();
            sq.Close();
            }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forgotpassword fp = new Forgotpassword();
            fp.Show();
        }

}


        }

      
    
