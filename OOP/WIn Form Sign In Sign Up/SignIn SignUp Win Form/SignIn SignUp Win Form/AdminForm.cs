using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BMS.DL;

namespace SignIn_SignUp_Win_Form
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

            //dataGridView1.DataSource = ListsDLUser.getListOfAdminandManager();
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click_2(object sender, EventArgs e)
        {
            AddEmployeeForm ae1 = new AddEmployeeForm();
            this.Hide();
            ae1.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
             ViewAllEmployee vE = new ViewAllEmployee();
            vE.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            ViewAllCustomer vC = new ViewAllCustomer();
            vC.Show();
            this.Hide();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();

        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeRemove eR = new EmployeeRemove();
            eR.Show();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            AdminPersonal aP = new AdminPersonal();
            aP.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            CustomerRemove cR = new CustomerRemove();
            cR.Show();
            this.Hide();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            if(ListsDLUser.getlistOfBank().Count == 0)
            {
                Bank b = new Bank();
                b.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Bank Data Already Added!!!");
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {
            BankData bD = new BankData();
            bD.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Employee_UpdateThrooughAdmin eA = new Employee_UpdateThrooughAdmin();
            eA.Show();
            this.Hide();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            AdminUpdate aU = new AdminUpdate();
            aU.Show();
            this.Hide();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            UpdateBank uB = new UpdateBank();
            uB.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            AdminLoan aL = new AdminLoan();
            aL.Show();
            this.Hide();
        }

        private void notebox_Click(object sender, EventArgs e)
        {
            Note n = new Note();
            n.Show();
            this.Hide();
        }
    }
}
