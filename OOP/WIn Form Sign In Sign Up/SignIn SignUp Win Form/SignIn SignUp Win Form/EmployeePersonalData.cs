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
    public partial class EmployeePersonalData : Form
    {
        public EmployeePersonalData()
        {
            InitializeComponent();
        }

        private void EmployeePersonalData_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(EmployeeDL.getListofEmloyee()[EmployeeDL.specificIndexForEmployee].Email, EmployeeDL.getListofEmloyee()[EmployeeDL.specificIndexForEmployee].Name, EmployeeDL.getListofEmloyee()[EmployeeDL.specificIndexForEmployee].Password, EmployeeDL.getListofEmloyee()[EmployeeDL.specificIndexForEmployee].Address, EmployeeDL.getListofEmloyee()[EmployeeDL.specificIndexForEmployee].PhoneNo, EmployeeDL.getListofEmloyee()[EmployeeDL.specificIndexForEmployee].CNIC, EmployeeDL.getListofEmloyee()[EmployeeDL.specificIndexForEmployee].EmployeeId, EmployeeDL.getListofEmloyee()[EmployeeDL.specificIndexForEmployee].Salary, EmployeeDL.getListofEmloyee()[EmployeeDL.specificIndexForEmployee].JoinDate);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeMenu eM = new EmployeeMenu();
            eM.Show();
            this.Hide();
        }
    }
}
