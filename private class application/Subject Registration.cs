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
    public partial class Subject_Registration : Form
    {
        public Subject_Registration()
        {
            InitializeComponent();
        }
        SqlConnection sq = new SqlConnection(Properties.Settings.Default.con);

        private void button2_Click(object sender, EventArgs e)
        {
            Login1 l1 = new Login1();
            l1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sq.Open();
            SqlCommand sc = new SqlCommand("INSERT INTO Subregistration (SubName, SubCode, Subfee)VALUES('"+subname.Text+"','"+subcode.Text+"','"+Subfees.Text+"')", sq);
            sc.ExecuteNonQuery();
            MessageBox.Show("Subject Registration Successfull");
            sq.Close();

        }
    }
}
