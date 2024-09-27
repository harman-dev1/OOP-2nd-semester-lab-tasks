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
    public partial class TransferAmount : Form
    {
        public TransferAmount()
        {
            InitializeComponent();
        }

        private void TransferAmount_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string atm = atmBox.Text;
            string check = CustomerDL.verifyATM(atm);
            CustomerDL.atmINdex = CustomerDL.indexForATM(atmBox.Text);
            if(check == "same")
            {
                MessageBox.Show("OOPs!!! Sender and Reciever Both are the same This Transaction can not be perormed");
                atmBox.Text = "";
            }
            else if(check == "false")
            {
                MessageBox.Show("OOPs!!! Reciever not found This Transaction can not be perormed");
                atmBox.Text = "";
            }
            else
            {
                _2Transfer_Amount_2 t = new _2Transfer_Amount_2();
                t.Show();
                this.Hide();
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CurrentAccountType cT = new CurrentAccountType();
            cT.Show();
            this.Hide();
        }
    }
}
