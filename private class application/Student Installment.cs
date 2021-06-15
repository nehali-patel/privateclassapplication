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
    public partial class Student_Installment : Form
    {
        public Student_Installment()
        {
            InitializeComponent();
        }
        SqlConnection sq = new SqlConnection(Properties.Settings.Default.con);

        String remain;
        private void button1_Click(object sender, EventArgs e)
        {
            txtremain.Text = (Convert.ToInt32(txttotal.Text) - Convert.ToInt32(txtpaid.Text)).ToString();

            remain = txtremain.Text;
            sq.Open();
            SqlCommand sc = new SqlCommand("INSERT INTO StudentInstallments  ([Student Name], [Total Fees], [Paid Fees], [Remaining Fees]) VALUES('"+studname .Text+"','"+txttotal.Text +"','"+txtpaid .Text +"','"+remain +"')", sq);
            sc.ExecuteNonQuery();
            sq.Close();

            

        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            Login1 l1 = new Login1();
            l1.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlDataReader sdr = null;
            sq.Open();
            SqlCommand sc1=new SqlCommand ("SELECT [Total Fees], [Paid Fees], [Remaining Fees] FROM StudentInstallments WHERE ([Student Name]='"+comboBox1 .SelectedItem.ToString ()+"')",sq);
            sdr = sc1.ExecuteReader();
            while (sdr.Read())
            {
                textBox2.Text = sdr["Total Fees"].ToString();

                textBox3.Text = sdr["Paid Fees"].ToString();
                textBox4.Text = sdr["Remaining Fees"].ToString();
            }
            sdr.Close();
            sq.Close();


        }

        private void Student_Installment_Load(object sender, EventArgs e)
        {
            SqlDataReader sdr = null;
            sq.Open();
            SqlCommand sc2 = new SqlCommand("SELECT [Student Name] FROM  StudentInstallments", sq);
            sdr = sc2.ExecuteReader();
            while (sdr.Read())
            {
               comboBox1 .Items .Add(sdr["Student Name"].ToString()) ;

               
            }
            sdr.Close();
            sq.Close();

        }

       
    }
}

