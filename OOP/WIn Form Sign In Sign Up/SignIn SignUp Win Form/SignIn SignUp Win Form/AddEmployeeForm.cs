using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BMS.BL;
using BMS.DL;

namespace SignIn_SignUp_Win_Form
{
    public partial class AddEmployeeForm : Form
    {
        string path = "Employee.txt";
        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            this.Close();
            home.Show();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            
            string emailEmployee = emailBox.Text;
            while (EmployeeDL.checkUserAlreadyExisted(emailEmployee) == false)
            {
                MessageBox.Show("Email Already Existed!!! Plzz Enter Unique Email ");
                emailBox.Text = "";
                return;
            }
            while ((EmployeeDL.checkEmail(emailEmployee) == false))
            {

                MessageBox.Show("Email Is not in a Correct Format ");
                emailBox.Text = "";
                return;
            }
            string emailPassword = emailPassBox.Text;

            string nameEmployee = NameBox.Text;
            long cnic = Convert.ToInt64(CnicBox.Text);
            while (EmployeeDL.checkCNIC(cnic) == false)
            {
                MessageBox.Show("CNIC must be 13 digit and first digit must be \"3\" as in Pakistan ");
                CnicBox.Text = "";
                return;
            }
            while (EmployeeDL.checkCNICAlreadyExisted(cnic) == false)
            {
                MessageBox.Show("CNIC Already Existed!!! Plzz Enter Unique CNIC");
                CnicBox.Text = "";
                return;
            }
            long phoneNo = Convert.ToInt64(phonNoBox.Text);
            while (EmployeeDL.checkPhoneNo(phoneNo) == false)
            {
                MessageBox.Show("Phone No must be 11 digit and first digit must be 0 as in Pakistan ");
                phonNoBox.Text = "";
                return;
            }
            while (EmployeeDL.checkPhonNoAlreadyExisted(phoneNo) == false)
            {
                MessageBox.Show("Phone No Already Existed!!! Plzz Enter Unique Phone No ");
                phonNoBox.Text = "";
                return;
            }
            string employeeId = employeeIdBox.Text;
            while(EmployeeDL.checkEmployeeId(employeeId) == false)
            {
                MessageBox.Show("Employee Id Already Existed");
                employeeIdBox.Text = "";
                return;
            }
            long employeeSalary = Convert.ToInt64(employeeSalaryBox.Text);
            while(employeeSalary < 17000 || employeeSalary > 70000)
            {
                MessageBox.Show("Set Salary Between 17000 to 70000$");
                employeeSalaryBox.Text = "";
                return;
            }
            string address = AddressBox.Text;
            DateTime join = Convert.ToDateTime(dateTimePicker1.Text);

            EmployeeBL a1 = new EmployeeBL(emailEmployee, emailPassword, cnic, address, phoneNo, nameEmployee, "EMPLOYEE");

            a1.setExtraEmployeeInformation(employeeId, employeeSalary, join);
            EmployeeDL.setListOfEmployee(a1);
            string path = "Employee.txt";
            EmployeeDL.add_EmployeesInTo_file(path, emailEmployee, emailPassword, nameEmployee, address, phoneNo, cnic, employeeId, employeeSalary, join);
            MessageBox.Show("Data Save Successfully ");
            this.Hide();
            AddEmployeeForm student = new AddEmployeeForm();
            student.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminForm menu = new AdminForm();
            this.Hide();
            menu.Show();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            this.Close();
            home.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
