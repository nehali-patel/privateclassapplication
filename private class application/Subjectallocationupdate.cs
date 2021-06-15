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
    public partial class Subjectallocationupdate : Form
    {
        public Subjectallocationupdate()
        {
            InitializeComponent();
        }
        SqlConnection sq = new SqlConnection(Properties.Settings.Default.con);
        private void button3_Click(object sender, EventArgs e)
        {
            Login1 l = new Login1();
            l.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sq.Open();
            SqlCommand sc = new SqlCommand(" UPDATE SubAllocation SET Subject ='"+txtsub.Text +"', staffid ='"+txtstaffid .Text+"'", sq);
            sc.ExecuteNonQuery();
            sq.Close();
            MessageBox.Show("Record updated ");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataReader sdr = null;
            sq.Open();
            SqlCommand sc1 = new SqlCommand("SELECT Subject, staffid FROM SubAllocation Where([staffname]='" + comboBox1.SelectedItem.ToString() + "')", sq);
            //SqlCommand sc1=new SqlCommand ("SELECT Mname, HomeAdd, City, district, Pincode, Contact, UID, EmailID, DOB, Age, Gender, GFname, GMname, GLname, GContact FROM StudentRegistration1 WHERE (Fname='"+ComboBox2 .SelectedItem.ToString ()+"')",sq);
            sdr = sc1.ExecuteReader();
            while (sdr.Read())
            {
                txtsub.Text = sdr["Subject"].ToString();
                txtstaffid.Text = sdr["staffid"].ToString();
               
                
               


            }

            sdr.Close();
            sq.Close();
        }
    }
}
