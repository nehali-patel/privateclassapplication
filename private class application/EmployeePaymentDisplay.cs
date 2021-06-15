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
    public partial class EmployeePaymentDisplay : Form
    {
        public EmployeePaymentDisplay()
        {
            InitializeComponent();
        }

        private void Display_Click(object sender, EventArgs e)
        {
            using (SqlConnection sq = new SqlConnection(Properties.Settings.Default.con))
            {
                using (SqlCommand sc = new SqlCommand("SELECT  Paymentperannum, Paymentpermonth FROM EmployeePayment", sq))
                {
                    sc.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(sc))
                    {
                        using (DataTable dt2 = new DataTable())
                        {
                            sda.Fill(dt2);
                            dataGridView1.DataSource = dt2;
                        }
                    }

                }
            }
        }
    }
}
