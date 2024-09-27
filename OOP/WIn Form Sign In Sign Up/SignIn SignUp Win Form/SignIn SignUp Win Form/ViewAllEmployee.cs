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
    public partial class ViewAllEmployee : Form
    {
        public ViewAllEmployee()
        {
            InitializeComponent();
        }

        private void ViewAllEmployee_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = EmployeeDL.getListofEmloyee(); // introspection
        }

        

        private void label3_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string employeeEmail = employeeEmailBox.Text;
            EmployeeDL.checkEmployee(employeeEmail);
            dataGridView1.Refresh();
            List<EmployeeBL> employee =  EmployeeDL.getlistOfEmployeeForSearch();
            dataGridView1.DataSource = employee;
            
            
        }
        public void dataBind()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = EmployeeDL.getlistOfEmployeeForSearch();
            dataGridView1.Refresh();
        }
        private void label2_Click_1(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            AdminForm aF = new AdminForm();
            aF.Show();
            this.Hide();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            employeeEmailBox.Clear();
            List<EmployeeBL> employee = EmployeeDL.getlistOfEmployeeForSearch();
            for (int i = 0; i < EmployeeDL.getlistOfEmployeeForSearch().Count; i++)
            {
                EmployeeDL.getlistOfEmployeeForSearch().RemoveAt(i);
            }
            dataGridView1.DataSource = null;
            viewAllemployeeLoad(this,null);
            dataGridView1.DataSource = EmployeeDL.getListofEmloyee();

        }
        private void viewAllemployeeLoad(object sender, EventArgs e)
        {
            refreshGrid();
        }
        private void refreshGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = EmployeeDL.getListofEmloyee();
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
