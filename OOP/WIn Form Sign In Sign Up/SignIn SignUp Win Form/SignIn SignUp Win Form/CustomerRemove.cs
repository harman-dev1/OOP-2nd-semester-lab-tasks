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
    public partial class CustomerRemove : Form
    {
        public CustomerRemove()
        {
            InitializeComponent();
        }
        //private void RemoveRowFromDataGridView(int rowIndex)
        //{
        //    if (dataGridView1.SelectedRows.Count > 0)
        //    {
        //        DataRowView selectedRow = dataGridView1.SelectedRows[0].DataBoundItem as DataRowView;
        //        if (selectedRow != null)
        //        {
        //            DataRow rowToRemove = selectedRow.Row;
        //            dat.Rows.Remove(rowToRemove);
        //        }
        //    }
        //}
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "Remove")
            {
               // Get the customer object from the clicked row
               CustomerBL user = dataGridView1.Rows[e.RowIndex].DataBoundItem as CustomerBL;

                if (user != null)
                {
                   // Assuming 
                        //CustomerDL.deleteCustomerFromList is a static method
                    CustomerDL.deleteCustomerFromList(user);
                    dataBind(); // Assuming this method updates the DataGridView with the new data
                    MessageBox.Show("Data Deleted Successfully");
                }
            }
            CustomerDL.getListofCustomer().RemoveAt(dataGridView1.SelectedRows[0].Index);

        }
        public void dataBind()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = CustomerDL.getlistOfCustomerForSearch();
            dataGridView1.Refresh();
        }

        private void CustomerRemove_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = CustomerDL.getListofCustomer();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            AdminForm aF = new AdminForm();
            aF.Show();
            this.Hide();
        }

      

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndexToRemove = dataGridView1.CurrentRow.Index;

            // Call the method to remove the specific row
            //RemoveRowFromDataGridView(rowIndexToRemove);
            
        }
    }
}
