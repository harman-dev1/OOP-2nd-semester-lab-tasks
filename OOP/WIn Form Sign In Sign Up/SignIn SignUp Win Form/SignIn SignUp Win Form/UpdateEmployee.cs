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
    public partial class UpdateEmployee : Form
    {
        public UpdateEmployee()
        {
            InitializeComponent();
        }
        private void UpdateEmployee_Load(object sender, EventArgs e)
        {
            MessageBox.Show("You can not Update Your Salary Id and Date Of Joining Only Admin Can Update it You can Only Update Other Personal Information");
            emailbtt.Text = EmployeeDL.getListofEmloyee()[EmployeeDL.specificIndexForEmployee].Email;
            passwordbtt.Text = EmployeeDL.getListofEmloyee()[EmployeeDL.specificIndexForEmployee].Password;
            Namebtt.Text = EmployeeDL.getListofEmloyee()[EmployeeDL.specificIndexForEmployee].Name;
            addressBtt.Text = EmployeeDL.getListofEmloyee()[EmployeeDL.specificIndexForEmployee].Address;
            phnobtt.Text = Convert.ToString(EmployeeDL.getListofEmloyee()[EmployeeDL.specificIndexForEmployee].PhoneNo);
            cnicbtt.Text = Convert.ToString(EmployeeDL.getListofEmloyee()[EmployeeDL.specificIndexForEmployee].CNIC);
            salaryBtt.Text = Convert.ToString(EmployeeDL.getListofEmloyee()[EmployeeDL.specificIndexForEmployee].Salary);
            idbtt.Text = Convert.ToString(EmployeeDL.getListofEmloyee()[EmployeeDL.specificIndexForEmployee].EmployeeId);
            dateBox.Text = EmployeeDL.getListofEmloyee()[EmployeeDL.specificIndexForEmployee].JoinDate.ToString();
        }   
        private void button2_Click(object sender, EventArgs e)
        {
            EmployeeDL.getListofEmloyee()[EmployeeDL.specificIndexForEmployee].Name = Namebtt.Text;
            EmployeeDL.getListofEmloyee()[EmployeeDL.specificIndexForEmployee].Email = emailbtt.Text;
            EmployeeDL.getListofEmloyee()[EmployeeDL.specificIndexForEmployee].Password = passwordbtt.Text;
            EmployeeDL.getListofEmloyee()[EmployeeDL.specificIndexForEmployee].CNIC = Convert.ToInt64(cnicbtt.Text);
            EmployeeDL.getListofEmloyee()[EmployeeDL.specificIndexForEmployee].PhoneNo = Convert.ToInt64(phnobtt.Text);
            EmployeeDL.getListofEmloyee()[EmployeeDL.specificIndexForEmployee].Address = addressBtt.Text;
            EmployeeDL.getListofEmloyee()[EmployeeDL.specificIndexForEmployee].EmployeeId = idbtt.Text;
            EmployeeDL.getListofEmloyee()[EmployeeDL.specificIndexForEmployee].Salary = Convert.ToInt64(salaryBtt.Text);
            EmployeeDL.getListofEmloyee()[EmployeeDL.specificIndexForEmployee].JoinDate = Convert.ToDateTime(dateBox.Text);
            EmployeeDL.add_EmployeesInTo_file2("Employee.txt", EmployeeDL.getListofEmloyee());
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
            dateBox.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeMenu eM = new EmployeeMenu();
            eM.Show();
            this.Hide();
        }
    }
}
