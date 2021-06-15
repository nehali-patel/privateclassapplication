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
    public partial class Subject_Allocation : Form
    {
        public Subject_Allocation()
        {
            InitializeComponent();
        }
        SqlConnection sq = new SqlConnection(Properties.Settings.Default.con);
        private void button3_Click(object sender, EventArgs e)
        {
            Login1 l1 = new Login1();
            l1.Show();
            this.Hide();
        }

        private void Subject_Allocation_Load(object sender, EventArgs e)
        {

        }

        private void btnsubmit_Click_1(object sender, EventArgs e)
        {
            sq.Open();
            SqlCommand sc = new SqlCommand("INSERT INTO SubAllocation (Subject, Staffname, staffid)VALUES('"+textBox1 .Text+"','"+textBox2 .Text +"','"+textBox3 .Text +"')", sq);
            sc.ExecuteNonQuery();
            sq.Close();
            MessageBox.Show("subject Allocated");


        }
    }
}
