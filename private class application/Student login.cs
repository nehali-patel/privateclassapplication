using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace private_class_application
{
    public partial class Student_login : Form
    {
        public Student_login()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            String pass = "student123";
            String ID = "Student";
            if (txtID.Text==(ID))
            {
                if (txtpass.Text ==(pass))
                {
                    MessageBox.Show("Login Succesfull");


                    Registration re = new Registration();
                    re.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Id or Password wrong");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();

        }
    }
}
