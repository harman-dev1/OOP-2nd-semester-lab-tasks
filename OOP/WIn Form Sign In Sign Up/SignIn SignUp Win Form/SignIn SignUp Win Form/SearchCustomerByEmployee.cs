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
    public partial class SearchCustomerByEmployee : Form
    {
        public SearchCustomerByEmployee()
        {
            InitializeComponent();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            EmployeeMenu eM = new EmployeeMenu();
            eM.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void SearchCustomerByEmployee_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = CustomerDL.getListofCustomer();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string customerEmail = customerEmailBox.Text;
            CustomerDL.checkCustomer(customerEmail);
            dataGridView1.Refresh();
            dataGridView1.DataSource = CustomerDL.getlistOfCustomerForSearch();
        }
        public void dataBind()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = CustomerDL.getlistOfCustomerForSearch();
            dataGridView1.Refresh();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            customerEmailBox.Clear();
            //List<EmployeeBL> employee = EmployeeDL.getlistOfEmployeeForSearch();
            for (int i = 0; i < CustomerDL.getlistOfCustomerForSearch().Count; i++)
            {
                CustomerDL.getlistOfCustomerForSearch().RemoveAt(i);
            }
            dataGridView1.DataSource = null;
            viewAllCustomerLoad(this, null);
            dataGridView1.DataSource = CustomerDL.getListofCustomer();
        }
        private void viewAllCustomerLoad(object sender, EventArgs e)
        {
            refreshGrid();
        }
        private void refreshGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = CustomerDL.getListofCustomer();
            dataGridView1.Refresh();
        }
    }
}
