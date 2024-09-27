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
    public partial class Employee_UpdateThrooughAdmin : Form
    {
        public Employee_UpdateThrooughAdmin()
        {
            InitializeComponent();
        }
        EmployeeBL eeee = new EmployeeBL();
        private void SearchBtt_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            if(textBox1.Text != null)
            {
                EmployeeBL eL = EmployeeDL.employee_remove(email);
                eeee = eL;
                if(eL != null)
                {
                    emailbtt.Text = eL.Email;
                    passwordbtt.Text = eL.Password;
                    Namebtt.Text = eL.Name;
                    addressBtt.Text = eL.Address;
                    phnobtt.Text = Convert.ToString(eL.PhoneNo);
                    cnicbtt.Text = Convert.ToString(eL.CNIC);
                    salaryBtt.Text = Convert.ToString(eL.Salary);
                    idbtt.Text = Convert.ToString(eL.EmployeeId);
                    dateTimePicker1.Text = eL.JoinDate.ToString();
                }
                else
                {
                    MessageBox.Show("Employee Not Found");
                    clear();
                }
            }
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminForm aF = new AdminForm();
            aF.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            eeee.Name = Namebtt.Text;
            eeee.Email = emailbtt.Text;
            eeee.Password = passwordbtt.Text;
            eeee.CNIC = Convert.ToInt64(cnicbtt.Text);
            eeee.PhoneNo = Convert.ToInt64(phnobtt.Text);
            eeee.Address = addressBtt.Text;
            eeee.EmployeeId = idbtt.Text;
            eeee.Salary = Convert.ToInt64(salaryBtt.Text);
            eeee.JoinDate = Convert.ToDateTime(dateTimePicker1.Text);
            EmployeeDL.add_EmployeesInTo_file2("Employee.txt",EmployeeDL.getListofEmloyee());
            MessageBox.Show("Updated Successfully");
            clear();
        }
        private void clear()
        {
            Namebtt.Text = "";
            emailbtt.Text = "";
            passwordbtt.Text = "";
            cnicbtt.Text = "";
            phnobtt.Text = "";
            addressBtt.Text = "";
            idbtt.Text = "";
            salaryBtt.Text = "";
            dateTimePicker1.Text = "";
        }

        private void Employee_UpdateThrooughAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
