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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnadmin_Click(object sender, EventArgs e)
        {
            login l = new login ();
            l.Show();
            this.Hide();
        }

        private void btnstudent_Click(object sender, EventArgs e)
        {
            Student_login  l = new Student_login ();
            l.Show();
            this.Hide();
        }

        
    }
}
