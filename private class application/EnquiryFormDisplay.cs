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
    public partial class EnquiryFormDisplay : Form
    {
        public EnquiryFormDisplay()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sq = new SqlConnection(Properties.Settings.Default.con))
            {
                using (SqlCommand sc = new SqlCommand("SELECT Courses_Available, Studentname, Fathername, Gender, DOB, Address, ContactNo, EmailID, Subjects, Courses_Available, Studentname, Fathername, Gender, DOB, Address, ContactNo FROM EnquiryformDetails", sq))
                {
                    sc.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(sc))
                    {
                        using (DataTable dt1 = new DataTable())
                        {
                            sda.Fill(dt1);
                            dataGridView1.DataSource = dt1;
                        }
                    }

                }
            }
        }
    }
}
