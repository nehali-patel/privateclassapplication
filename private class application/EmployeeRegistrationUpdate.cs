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
    public partial class EmployeeRegistrationUpdate : Form
    {
        public EmployeeRegistrationUpdate()
        {
            InitializeComponent();
        }
        SqlConnection sq = new SqlConnection(Properties.Settings.Default.con);
       
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataReader sdr = null;
            sq.Open();
            SqlCommand sc1 = new SqlCommand("SELECT EMName, ELName, homeAdd, City, District, Pincode, [Contact _no], UID, Email_ID, DOB, Gender, Age FROM  [Employee _registration] WHERE (EFName='" + comboBox1.SelectedItem.ToString() + "')", sq);
            //SqlCommand sc1=new SqlCommand ("SELECT Mname, HomeAdd, City, district, Pincode, Contact, UID, EmailID, DOB, Age, Gender, GFname, GMname, GLname, GContact FROM StudentRegistration1 WHERE (Fname='"+ComboBox2 .SelectedItem.ToString ()+"')",sq);
            sdr = sc1.ExecuteReader();
            while (sdr.Read())
            {
                txtmname.Text = sdr["EMName"].ToString();

                txtlname.Text = sdr["ELName"].ToString();
                txthadd.Text = sdr["homeAdd"].ToString();
                txtcity.Text = sdr["City"].ToString();
                txtdist.Text = sdr["District"].ToString();
                txtpin.Text = sdr["Pincode"].ToString();
                txtcontact.Text = sdr["Contact _no"].ToString();
                txtUID.Text = sdr["UID"].ToString();
                txtemail.Text = sdr["Email_ID"].ToString();
                dateTimePicker1 .Text  = sdr["DOB"].ToString();
              textBox1.Text = sdr["Gender"].ToString();
                txtage .Text  = sdr["Age"].ToString();


                
            }

            sdr.Close();
            sq.Close();
               }

        private void EmployeeRegistrationUpdate_Load(object sender, EventArgs e)
        {
            SqlDataReader sdr = null;
            sq.Open();
            SqlCommand sc2 = new SqlCommand("SELECT EFName FROM [Employee _registration]", sq);
            sdr = sc2.ExecuteReader();
            while (sdr.Read())
            {
                comboBox1.Items.Add(sdr["EFName"].ToString());


            }
            sdr.Close();
            sq.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sq.Open();
            SqlCommand sc = new SqlCommand(" UPDATE [Employee _registration] SET EMName ='"+txtmname .Text +"', ELName ='"+txtlname .Text +"', homeAdd ='"+txthadd .Text +"', City ='"+txtcity .Text +"', District ='"+txtdist.Text +"', Pincode ='"+txtpin .Text+ "', [Contact _no] ='"+txtcontact .Text +"', UID ='"+txtUID .Text +"', Email_ID ='"+txtemail .Text +"', DOB ='"+dateTimePicker1 .Text +"', Gender ='"+textBox1 .Text +"', Age ='"+txtage .Text +"' Where([EFName]='" + comboBox1.SelectedItem.ToString() + "')", sq);
            sc.ExecuteNonQuery();
            sq.Close();
            MessageBox.Show("Record updated ");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sq.Open();
            SqlCommand sc = new SqlCommand("DELETE FROM [Employee _registration] Where([EFName]='" + comboBox1.SelectedItem.ToString() + "')", sq);
            sc.ExecuteNonQuery();
            sq.Close();
            MessageBox.Show("Record Deleted");


        }
    }
}
