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
    public partial class Employee_Registration : Form
    {
        public Employee_Registration()
        {
            InitializeComponent();
        }
        String Gender;
        SqlConnection sq = new SqlConnection(Properties.Settings.Default.con);

        private void button2_Click(object sender, EventArgs e)
        {
            Login1 l1 = new Login1();
            l1.Show();
            this.Hide();
        }

        

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            sq.Open();
            SqlCommand sc = new SqlCommand("INSERT INTO [Employee _registration] (EFName, EMName, ELName, homeAdd, City, District, Pincode, [Contact _no], UID, Email_ID, DOB, Gender, Age)VALUES('" + txtfname.Text + "','" + txtmname.Text + "','" + txtlname.Text + "','" + txthadd.Text + "','" + txtcity.Text + "','" + txtdist.Text + "','" + txtpin.Text + "','" + txtcontact.Text + "','" + txtUID.Text + "','" + txtemail.Text + "','" + dateTimePicker1.Value.ToShortDateString() + "','" +Gender +"','" + txtage.Text + "')", sq);
            sc.ExecuteNonQuery ();
            sq.Close ();
            MessageBox.Show("Registered Successfully");

        }

        private void rdmale_CheckedChanged(object sender, EventArgs e)
        {
            if (rdmale.Checked==true)
            {
                Gender = "Male";
            }

        }

        private void rdfemale_CheckedChanged(object sender, EventArgs e)
        {
            if (rdfemale.Checked==true)
            {
                Gender = "female";
            }
        }
    }
}
