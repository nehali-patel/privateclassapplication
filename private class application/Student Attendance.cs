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
    public partial class Student_Attendance : Form
    {
        public Student_Attendance()
        {
            InitializeComponent();
        }
        String attendance;
        SqlConnection sq = new SqlConnection(Properties.Settings.Default.con);


        private void btnback_Click(object sender, EventArgs e)
        {
            Login1 l1 = new Login1();
            l1.Show();
            this.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                attendance = "Present";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                attendance = "Absent";
            }
        }
        private void btnsubmit_Click(object sender, EventArgs e)
        {
           
            sq.Open();
            SqlCommand sc = new SqlCommand("INSERT INTO StudentAttendance(StudentID, StudentName, status)VALUES  ('"+textBox1.Text +"','"+textBox2 .Text +"','"+attendance +"')", sq);
            sc.ExecuteNonQuery();
            sq.Close();
            MessageBox.Show("Attendance is feeded successfully");
            
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataReader sdr = null;
            sq.Open();
            SqlCommand sc1 = new SqlCommand("SELECT StudentID, status FROM   StudentAttendance Where([StudentName]='"+comboBox1 .SelectedItem .ToString() +"')", sq);
            sdr = sc1.ExecuteReader();
            while (sdr.Read())
            {
                textBox4.Text = sdr["StudentID"].ToString();

               
                textBox5.Text = sdr["status"].ToString();
            }
            sdr.Close();
            sq.Close();
        }

        private void Student_Attendance_Load(object sender, EventArgs e)
        {
            SqlDataReader sdr = null;
            sq.Open();
            SqlCommand sc2 = new SqlCommand("SELECT StudentName FROM StudentAttendance", sq);
            sdr = sc2.ExecuteReader();
            while (sdr.Read())
            {
                comboBox1.Items.Add(sdr["StudentName"].ToString());


            }
            sdr.Close();
            sq.Close();
        }

        
    }
}
