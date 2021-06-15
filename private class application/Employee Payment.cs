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
    public partial class Employee_Payment : Form
    {
        public Employee_Payment()
        {
            InitializeComponent();
        }
        String presentdays;
        SqlConnection sq = new SqlConnection(Properties.Settings.Default.con);

                     // Integrated Security=True;MultipleActiveResultSets=True");
        private void btnback_Click(object sender, EventArgs e)
        {
            Login1 l1 = new Login1();
            l1.Show();
            this.Hide();
        }

        

        private void btnshow_Click(object sender, EventArgs e)
        {
            sq.Open();
            txtmonth.Text = (Convert.ToInt32(txtannum.Text) / 12).ToString ();
            txtday .Text  = (Convert.ToInt32(txtmonth.Text) / 30).ToString();
            SqlCommand sc = new SqlCommand("INSERT INTO EmployeePayments(EmployeeName, EmployeeID, Paymentperannum, Paymentpermonth, Paymentperdat)VALUES ('"+txtename .Text +"','" + txtid .Text  + "','" + txtannum .Text  + "','"+txtmonth .Text +"','"+txtday .Text+"')", sq);
            sc.ExecuteNonQuery();
            sq.Close();
            MessageBox.Show("Salary Entered Successfully");

        }
       
        

       /* private void button1_Click(object sender, EventArgs e)
        {

            SqlDataReader sdr = null;
           
            sq.Open();
            
                       SqlCommand sc1 = new SqlCommand("SELECT  EmployeeName, EmployeeID, Paymentperannum, Paymentpermonth,Paymentperdat FROM EmployeePayments WHERE ([EmployeeID]='" + comboBox1.SelectedItem.ToString() + "')", sq);
            sdr = sc1.ExecuteReader();
            
            while (sdr.Read())
            {
              
               txtdename .Text = sdr["EmployeeName"].ToString();
                txtdannum .Text  = sdr["Paymentperannum"].ToString();
                txtdday.Text = sdr["Paymentperdat"].ToString();
                txtdmonth.Text = sdr["Paymentpermonth"].ToString();
                
                
            }
            sdr.Close();
            
            sq.Close();


        }*/

        private void Employee_Payment_Load(object sender, EventArgs e)
        {
            SqlDataReader sdr = null;
            sq.Open();
            SqlCommand sc2 = new SqlCommand("SELECT  EmployeeName  FROM EmployeePayments", sq);
            sdr = sc2.ExecuteReader();
            while (sdr.Read())
            {
                comboBox1.Items.Add(sdr["EmployeeName"].ToString());

               
            }
            sdr.Close();
            sq.Close();

        }

        private void button2_Click(object sender,EventArgs e)
        {
            Double pkg = Convert.ToDouble(txtdannum.Text);
            pkg = pkg * 100000;
            txtdmonth.Text = (pkg / 12).ToString();
            Double salmonth = Convert.ToDouble(txtdmonth.Text);
            txtdday.Text = (salmonth / 30).ToString();

            sq.Open();

            SqlDataReader sdr1 = null;
            SqlCommand sc = new SqlCommand("SELECT Emplyeename,COUNT(*) AS Count FROM  EmployeeAttendance1 WHERE([Emplyeename]='" + comboBox1.SelectedItem.ToString() + "') AND(MONTH(Date)=MONTH({fn CURDATE()}))AND(Status='Present')GROUP BY Emplyeename ", sq);
            sdr1 = sc.ExecuteReader();
            sdr1.Read();
            presentdays = sdr1["Count"].ToString();
            MessageBox.Show("Number of present days:" + presentdays);
            double daysal = Convert.ToDouble(txtdday.Text);
            txtfinal .Text=(Convert .ToDouble(presentdays )*daysal).ToString();
            sdr1.Close();
            sq.Close();

        }
        }
    }

