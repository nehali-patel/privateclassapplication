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
    public partial class Login1 : Form
    {
        public Login1()
        {
            InitializeComponent();
        }

        private void btnempregister_Click(object sender, EventArgs e)
        {
            Employee_Registration er = new Employee_Registration();
            er.Show();
            this.Hide();

        }

        private void btnempattendance_Click(object sender, EventArgs e)
        {
            EmployeeAttendance ea = new EmployeeAttendance ();
            ea.Show();
            this.Hide();
        }

        private void Employeepayments_Click(object sender, EventArgs e)
        {
            Employee_Payment ep = new Employee_Payment ();
            ep.Show();
            this.Hide();
        }

        private void btnsubjectregister_Click(object sender, EventArgs e)
        {
            Subject_Registration sr = new Subject_Registration();
            sr.Show();
            this.Hide();

        }

        private void subjectallocation_Click(object sender, EventArgs e)
        {
            Subject_Allocation sa = new Subject_Allocation();
            sa.Show();
            this.Hide();
        }

        private void Studentattendance_Click(object sender, EventArgs e)
        {
            Student_Attendance sta = new Student_Attendance();
            sta.Show();
            this.Hide();

        }

        private void Stdentinstalments_Click(object sender, EventArgs e)
        {
            Student_Installment si = new Student_Installment();
            si.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmshow f = new frmshow();
            f.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EmployeeAttendanceDisplay e1 = new EmployeeAttendanceDisplay();
            e1.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            EmployeePaymentDisplay e2 = new EmployeePaymentDisplay();
            e2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SubjectRegistrationDisplay s1 = new SubjectRegistrationDisplay();
            s1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SubjectAllocationDisplay s2 = new SubjectAllocationDisplay();
            s2.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            StudentAttendanceDisplay sa1 = new StudentAttendanceDisplay();
            sa1.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            StudentInstallmentDisplay si1 = new StudentInstallmentDisplay();
            si1.Show();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            StudentRegistrationinfo s1 = new StudentRegistrationinfo();
            s1.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Subjectallocationupdate s1 = new Subjectallocationupdate();
            s1.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            NewAccount n1 = new NewAccount();
            n1.Show();
            this.Hide();
        }

        private void Login1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
