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
    public partial class EmployeeRemove : Form
    {
        public EmployeeRemove()
        {
            InitializeComponent();
        }

        private void EmployeeRemove_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = EmployeeDL.getListofEmloyee();
        }        
        public void dataBind()
        {
            
        }
        private void label2_Click(object sender, EventArgs e)
        {
            AdminForm aF = new AdminForm();
            aF.Show();
            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string employeeEmail = emailBox.Text;
            EmployeeDL.checkEmployee(employeeEmail);
            dataGridView1.Refresh();
            List<EmployeeBL> employee = EmployeeDL.getlistOfEmployeeForSearch();
            dataGridView1.DataSource = employee;
            
        }
        private void clear_data_from_form()
        {
            emailBox.Text = "";
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void backButt_Click(object sender, EventArgs e)
        {
            AdminForm aF = new AdminForm();
            aF.Show();
            this.Hide();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void resetBtton_Click(object sender, EventArgs e)
        {
            clear_data_from_form();
            emailBox.Clear();
            List<EmployeeBL> employee = EmployeeDL.getlistOfEmployeeForSearch();
            for (int i = 0; i < EmployeeDL.getlistOfEmployeeForSearch().Count; i++)
            {
                EmployeeDL.getlistOfEmployeeForSearch().RemoveAt(i);
            }
            dataGridView1.DataSource = null;
            viewAllemployeeLoad(this, null);
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
        private void removeButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
