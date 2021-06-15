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
    public partial class EmployeeAttendance : Form
    {
        public EmployeeAttendance()
        {
            InitializeComponent();
        }
        string Attendance;

        SqlConnection sq = new SqlConnection(Properties .Settings .Default .con);

        private void btnback_Click(object sender, EventArgs e)
        {
            Login1 l1 = new Login1();
            l1.Show();
            this.Hide();

        }

        private void rdpresent_CheckedChanged(object sender, EventArgs e)
        {
            if (rdpresent.Checked == true)
            {
                Attendance = "Present";
            }
        }

        private void rdabsent_CheckedChanged(object sender, EventArgs e)
        {
            if (rdabsent.Checked == true)
            {
                Attendance = "Absent";
            }
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            sq.Open();

            SqlCommand sc = new SqlCommand("INSERT INTO EmployeeAttendance1 (EmployeeID, Emplyeename, Date, Status)VALUES('" + txtempid.Text + "','" + txtempname.Text + "','" + dateTimePicker1.Value.ToShortDateString() + "','" + Attendance + "')", sq);
            sc.ExecuteNonQuery();
            sq.Close();
            MessageBox.Show("Attendance is feeded successfully");
            
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataReader sdr = null;
            sq.Open();
            SqlCommand sc1 = new SqlCommand(" SELECT EmployeeID, Date, Status FROM EmployeeAttendance1 Where([Emplyeename]='" + comboBox1.SelectedItem.ToString() + "')", sq);
            sdr = sc1.ExecuteReader();
            while (sdr.Read())
            {
                textBox2.Text = sdr["EmployeeID"].ToString();
                textBox4.Text = sdr["Date"].ToString();

                textBox1.Text = sdr["Status"].ToString();
            }
            sdr.Close();
            sq.Close();
        }


        private void EmployeeAttendance_Load(object sender, EventArgs e)
        {
            SqlDataReader sdr = null;
            sq.Open();
            SqlCommand sc2 = new SqlCommand("SELECT Emplyeename FROM EmployeeAttendance1", sq);
            sdr = sc2.ExecuteReader();
            while (sdr.Read())
            {
                comboBox1.Items.Add(sdr["Emplyeename"].ToString());


            }
            sdr.Close();
            sq.Close();
        }
    }
}
