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
    public partial class Enquiryform : Form
    {
        public Enquiryform()
        {
            InitializeComponent();
        }
        SqlConnection sq = new SqlConnection(Properties.Settings.Default.con);
        String Gender;

        String Subject;
        
        private void btnback_Click(object sender, EventArgs e)
        {
            Registration re2 = new Registration();
            re2.Show();
            this.Hide();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {

            sq.Open();


            if (cbmaths.Checked && cbsci.Checked && cbeng.Checked)
            {
                Subject = "Maths,Science,English";
            }
            else if (cbmaths.Checked && cbsci.Checked)
            {
                Subject = "Maths,Science";
            }
            else if (cbsci.Checked && cbeng.Checked)
            {
                Subject = "Science,English";
            }
            else if (cbmaths.Checked && cbeng.Checked)
            {
                Subject = "Maths,English";
            }
            else if (cbmaths.Checked)
            {
                Subject = "Maths";
            }
            else if (cbsci.Checked)
            {
                Subject = "Science";
            }
            else if (cbeng.Checked)
            {
                Subject = "English";
            }

            else
            {
                MessageBox.Show("Please select atleast one subject");
            }
            SqlCommand sc = new SqlCommand("INSERT INTO EnquiryformDetails  (Studentname, Courses_Available, Fathername, Gender, DOB, Address, ContactNo, EmailID, Subjects)VALUES('"+txtsname .Text+"','" + cmbcourses.SelectedItem.ToString() + "','"+Fname .Text +"','"+Gender+"','"+txtaddress .Text +"','"+dtdob.Value .ToShortDateString ()+"','"+txtcontact .Text +"','"+txtemail .Text +"','"+Subject+"')", sq);
            sc.ExecuteNonQuery();
            sq.Close();
            MessageBox.Show("Data inserted successfully");
        }

        private void rdmale_CheckedChanged(object sender, EventArgs e)
        {
            if (rdmale.Checked)
            {
                Gender = "male";
            }
        }

        private void rdfemale_CheckedChanged(object sender, EventArgs e)
        {
            if (rdfemale.Checked)
            {
                Gender = "female";
            }
        }
    }
}
