using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient ;

namespace private_class_application
{
    public partial class StudentRegistrationUpdate : Form
    {
        public StudentRegistrationUpdate()
        {
            InitializeComponent();
        }
        SqlConnection sq=new SqlConnection (Properties.Settings .Default .con );
       
           
       

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataReader sdr = null;
            sq.Open();
            SqlCommand sc1 = new SqlCommand("SELECT Lname,Mname, HomeAdd, City, district, Pincode, Contact, UID, EmailID, DOB, Age, GFname, GMname, GLname, GContact, Schoolname, Previouspercent, WeakSubjects, maths, science, english, Subjects, class, batch, date, paidfees FROM StudentRegistration2 WHERE (Fname='" + ComboBox2.SelectedItem.ToString() + "')", sq);
            //SqlCommand sc1=new SqlCommand ("SELECT Mname, HomeAdd, City, district, Pincode, Contact, UID, EmailID, DOB, Age, Gender, GFname, GMname, GLname, GContact FROM StudentRegistration1 WHERE (Fname='"+ComboBox2 .SelectedItem.ToString ()+"')",sq);
            sdr = sc1.ExecuteReader();
            while (sdr.Read())
            {
                txtMname.Text = sdr["Mname"].ToString();

                txtLname.Text = sdr["Lname"].ToString();
                txthadd.Text = sdr["HomeAdd"].ToString();
                txtcity.Text = sdr["City"].ToString();
                txtdist.Text = sdr["district"].ToString();
                txtpin.Text = sdr["Pincode"].ToString();
                txtcontact.Text = sdr["Contact"].ToString();
                txtUID.Text = sdr["UID"].ToString();
                txtemail.Text = sdr["EmailID"].ToString();
                dtpbdate.Text = sdr["DOB"].ToString();
                txtage.Text = sdr["Age"].ToString();
                txtgfname.Text = sdr["GFname"].ToString();
                txtglname.Text = sdr["GMname"].ToString();
                gcontact.Text = sdr["GLname"].ToString();
                txtschool.Text = sdr["Schoolname"].ToString();
                txtper.Text = sdr["Previouspercent"].ToString();
                txtweaksub.Text = sdr["WeakSubjects"].ToString();
                txtmaths.Text = sdr["maths"].ToString();
                txtscience.Text = sdr["science"].ToString();
                txtenglish.Text = sdr["english"].ToString();
                textBox1.Text = sdr["Subjects"].ToString();
                textBox3.Text = sdr["class"].ToString();
                textBox2.Text = sdr["batch"].ToString();
                txtdate.Text = sdr["date"].ToString();
                txtfees.Text = sdr["paidfees"].ToString();



            }
            sdr.Close();
            sq.Close();

        }

        private void StudentRegistrationUpdate_Load(object sender, EventArgs e)
        {
            SqlDataReader sdr = null;
            sq.Open();
            SqlCommand sc2 = new SqlCommand("SELECT Fname FROM StudentRegistration2", sq);
            sdr = sc2.ExecuteReader();
            while (sdr.Read())
            {
                ComboBox2.Items.Add(sdr["Fname"].ToString());


            }
            sdr.Close();
            sq.Close();


        }

        private void Update_Click(object sender, EventArgs e)
        {
            sq.Open();
            SqlCommand sc = new SqlCommand("UPDATE StudentRegistration2 SET  Mname ='"+txtMname .Text+"', Lname ='"+txtLname.Text +"', HomeAdd ='"+txthadd.Text +"', City ='"+txtcity .Text +"', district ='"+txtdist.Text +"', Pincode ='"+txtpin.Text +"', Contact ='"+txtcontact.Text+"', UID ='"+txtUID.Text+"', EmailID ='"+txtemail .Text+"', DOB ='"+dtpbdate.Text +"', Age ='"+txtage .Text +"', GFname ='"+txtgfname .Text +"', GMname ='"+gmname.Text  +"', GLname ='"+txtglname .Text+"', GContact ='"+gcontact .Text +"', Schoolname ='"+txtschool .Text +"', Previouspercent ='"+txtper .Text +"', WeakSubjects ='"+txtweaksub .Text +"', maths ='"+txtmaths .Text+"', science ='"+txtscience .Text+"', english ='"+txtenglish .Text +"', Subjects ='"+textBox1 .Text +"', class ='"+textBox3 .Text +"', batch ='"+textBox2 .Text+"', paidfees ='"+txtfees .Text+"', date ='"+txtdate .Text+"' Where([Fname]='"+ComboBox2 .SelectedItem .ToString ()+"')", sq);
            sc.ExecuteNonQuery();
            sq.Close();
            MessageBox.Show("Record updated ");

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            sq.Open();
            SqlCommand sc = new SqlCommand("DELETE FROM StudentRegistration2 Where([Fname]='" + ComboBox2.SelectedItem.ToString() + "')", sq);
            sc.ExecuteNonQuery();
            sq.Close();
            MessageBox.Show("Record Deleted");

        }
        }
        }
    
