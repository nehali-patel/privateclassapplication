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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }
        String Gender;
        String Subject, batch;


        SqlConnection sq = new SqlConnection(Properties.Settings.Default.con);



        private void button1_Click(object sender, EventArgs e)
        {
            Enquiryform en = new Enquiryform();
            en.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

       
            private void rdA_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rdB_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void rdC_CheckedChanged(object sender, EventArgs e)
        {
           
            
        }
             private void button1_Click_1(object sender, EventArgs e)
        {
            sq.Open();
            if (checkBox1.CheckState == CheckState.Checked && checkBox2.CheckState == CheckState.Checked && checkBox3.CheckState == CheckState.Checked)
            {
                Subject = "Maths,Science,English";
            }
            else if (checkBox1.CheckState == CheckState.Checked && checkBox2.CheckState == CheckState.Checked)
            {
                Subject = "Maths,Science";
            }
            else if (checkBox2.CheckState == CheckState.Checked && checkBox3.CheckState == CheckState.Checked)
            {
                Subject = "Science,English";
            }
            else if (checkBox1.CheckState == CheckState.Checked && checkBox3.CheckState == CheckState.Checked)
            {
                Subject = "Maths,English";
            }
            else if (checkBox1.CheckState == CheckState.Checked)
            {
                Subject = "Maths";
            }
            else if (checkBox2.CheckState == CheckState.Checked)
            {
                Subject = "Science";
            }
            else if (checkBox3.CheckState == CheckState.Checked)
            {
                Subject = "English";
            }

            else
            {
                MessageBox.Show("Please select atleast one subject");
            }
            if (rdA.Checked == true)
            {
                batch = "A";
            }
            else if (rdB.Checked == true)
            {
                batch = "B";
            }
            else
            {

                batch = "C";
            }


            // SqlCommand sc = new SqlCommand("INSERT INTO StudRegistratin   (Fname, Mname, Lname) VALUES ('"+txtfname .Text+"','"+txtmname.Text +"','"+txtlname .Text +"')", sq);
            //SqlCommand sc1 = new SqlCommand("INSERT INTO StudentRegistration1 (Fname, Mname, Lname, HomeAdd, City, district, Pincode, Contact, UID, EmailID, DOB, Age, Gender, GFname, GMname, GLname, GContact) VALUES ( '" + txtfname.Text + "','" + txtmname.Text + "','" + txtlname.Text + "','" + txthadd.Text + "','" + txtcity.Text + "','" + txtdist.Text + "','" + txtpin.Text + "','" + txtcontact.Text + "','" + txtUID.Text + "','" + txtemail.Text + "','" + dtpbdate.Value.ToShortDateString() + "','" + txtage.Text + "','" + Gender + "','" + txtgfname.Text + "','" + gmname.Text + "','" + txtglname.Text + "','" + gcontact.Text + "') ", sq);
            SqlCommand sc2 = new SqlCommand("INSERT INTO StudentRegistration2(Fname, Mname, Lname, HomeAdd, City, Pincode, district, Contact, UID, EmailID, DOB, Age, GFname, GMname, GLname, GContact, Schoolname, Previouspercent, WeakSubjects, maths, science, english, Subjects, class, batch, date, paidfees)VALUES  ( '" + txtfname.Text + "','" + txtmname.Text + "','" + txtlname.Text + "','" + txthadd.Text + "','" + txtcity.Text + "','" + txtdist.Text + "','" + txtpin.Text + "','" + txtcontact.Text + "','" + txtUID.Text + "','" + txtemail.Text + "','" + dtpbdate.Value.ToShortDateString() + "','" + txtage.Text + "','" + txtgfname.Text + "','" + gmname.Text + "','" + txtglname.Text + "','" + gcontact.Text + "','" + txtschool.Text + "','" + txtper.Text + "','" + txtweaksub.Text + "','" + txtmaths.Text + "','" + txtscience.Text + "','" + txtenglish.Text + "','" + Subject + "','" + comboBox1.SelectedItem.ToString() + "','" + batch + "','" + txtfees.Text + "','" + txtdate.Text + "')", sq);
            //sc.ExecuteNonQuery();
           
            // sc1.ExecuteNonQuery();
            sc2.ExecuteNonQuery();

            MessageBox.Show("record inserted");
            sq.Close();
        }



        private void Registration_Load(object sender, EventArgs e)
        {

        }

        /*private void rdmale_CheckedChanged(object sender, EventArgs e)
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
        }*/

        



        }
    }

