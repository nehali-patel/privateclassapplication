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
    public partial class Forgotpassword : Form
    {
        public Forgotpassword()
        {
            InitializeComponent();
        }
        SqlConnection sq = new SqlConnection(Properties .Settings .Default .con);
        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataReader sdr = null;
            sq.Open();
            SqlCommand sc2 = new SqlCommand("SELECT LoginName, Password, Answer FROM NamePassword", sq);
            sdr = sc2.ExecuteReader();
            while (sdr.Read())
            {
                if(user1.Text==sdr["LoginName"].ToString() && Answer1.Text ==sdr["Answer"].ToString())
                {
                    txtfp.Text = sdr["Password"].ToString();

                }
            }
            sq.Close();
            sdr.Close();
        }
    }
}
