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
    public partial class StudentRegistrationinfo : Form
    {
        public StudentRegistrationinfo()
        {
            InitializeComponent();
        }

        private void Personalinfo_Click(object sender, EventArgs e)
        {
            using (SqlConnection sq = new SqlConnection(Properties.Settings.Default.con))
            {
                using (SqlCommand sc = new SqlCommand("SELECT Fname, Mname, Lname, HomeAdd, City, district, Pincode, Contact, UID, EmailID, DOB, Age, GFname, GMname, GLname, GContact, Schoolname, Previouspercent, WeakSubjects, maths, science, english,Subjects, class, batch, paidfees, date FROM StudentRegistration2", sq))
                {
                    sc.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(sc))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }

                }
            }
        }






    }
}