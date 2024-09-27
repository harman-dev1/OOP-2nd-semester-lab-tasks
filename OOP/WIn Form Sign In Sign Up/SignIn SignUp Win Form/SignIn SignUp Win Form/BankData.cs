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
    public partial class BankData : Form
    {
        public BankData()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void BankData_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Add(ListsDLUser.getlistOfBank()[0].BankName, ListsDLUser.getlistOfBank()[0].BankEmail, ListsDLUser.getlistOfBank()[0].BankAdddress, ListsDLUser.getlistOfBank()[0].BankNo, ListsDLUser.getlistOfBank()[0].BankBranchID, ListsDLUser.getlistOfBank()[0].BankMoney);
            }
            catch
            {
                MessageBox.Show("Bank Data is not Added Yet!!!");
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                    

        }

        private void Backbtt_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}
