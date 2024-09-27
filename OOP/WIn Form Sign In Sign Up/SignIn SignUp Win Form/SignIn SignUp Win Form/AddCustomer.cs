using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using BMS.BL;
using BMS.DL;

namespace SignIn_SignUp_Win_Form
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string email = emailBox.Text;
            while(CustomerDL.checkUserAlreadyExisted(email) == false)
            {
                MessageBox.Show("Email Already Existed!!! Plzz Enter Unique Email ");
                emailBox.Text = "";
                return;
            }
            while ((CustomerDL.checkEmail(email) == false))
            {

                MessageBox.Show("Email Is not in a Correct Format ");
                emailBox.Text = "";
                return;
            }
            string emailPassword = emailPassBox.Text;
            string name = NameBox.Text;
            
            long cnic = Convert.ToInt64(CnicBox.Text);
            while (CustomerDL.checkCNIC(cnic) == false)
            {
                MessageBox.Show("CNIC must be 13 digit and first digit must be \"3\" as in Pakistan ");
                CnicBox.Text = "";
                return;
            }
            while(CustomerDL.checkCNICAlreadyExisted(cnic) == false)
            {
                MessageBox.Show("CNIC Already Existed!!! Plzz Enter Unique CNIC");
                CnicBox.Text = "";
                return;
            }
                long phoneNo = Convert.ToInt64(phonNoBox.Text);
            while (CustomerDL.checkPhoneNo(phoneNo) == false)
            {
                MessageBox.Show("Phone No must be 11 digit and first digit must be 0 as in Pakistan ");
               phonNoBox.Text = "";
                return;
            }
            while(CustomerDL.checkPhonNoAlreadyExisted(phoneNo) == false)
            {
                MessageBox.Show("Phone No Already Existed!!! Plzz Enter Unique Phone No ");
                phonNoBox.Text = "";
                return;
            }
             string atm = ATMIdBox.Text;
            while(CustomerDL.checkATMIdAlreadyExisted(atm) == false)
            {
                MessageBox.Show("ATM ID already in used Plzz Enter Unique Id!!!");
                ATMIdBox.Text = "";
                return;
            }
            int atmPassword = Convert.ToInt32(AtmPasswordBox.Text);
            while(CustomerDL.atmPasswordLength(atmPassword) == false)
            {
                MessageBox.Show("ATM password Length Must be 4 Plzz Enter 4 Digit PIN!!!");
                AtmPasswordBox.Text = "";
                return;
            }
            string accountType = acountTypeCombo.Text;
            string address = addressBox.Text;
            long amount = 0;
            CustomerBL c1 = new CustomerBL(email, emailPassword, cnic, address, phoneNo, name, "CUSTOMER");
            c1.SetAtmForCustomer(atm,atmPassword,accountType,amount);
            CustomerDL.setListOfCustomer(c1);
            string path = "Customer.txt";
            CustomerDL.add_CustomersInTo_file(path, c1);
            MessageBox.Show("Data Save Successfully ");
            this.Hide();
            AddCustomer ac = new AddCustomer();
            ac.Show();
        }
        public bool isValidName(string n)
        {
            Regex check = new Regex(@"^([A-Z][a-z-A-z]+)$");
            bool valid = false;
            valid = check.IsMatch(n);
            if (valid == true)
            {
                return valid;
            }
            else
            {
                MessageBox.Show("Name Format is Not a Correct");
                return valid;
            }
        }
        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeMenu em = new EmployeeMenu();
            em.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
