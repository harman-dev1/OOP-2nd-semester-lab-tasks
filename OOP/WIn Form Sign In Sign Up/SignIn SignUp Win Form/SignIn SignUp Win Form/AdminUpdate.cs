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
    public partial class AdminUpdate : Form
    {
        public AdminUpdate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Name = NameBox.Text;
            string Email = EmailBox.Text;
            string password = PasswordBox.Text;
            string PhoneNo = (PhoneNoBox.Text);
            string CNIC = (CNICBox.Text);
            string address = AddressBox.Text;
            long phNO = Convert.ToInt64(PhoneNo);
            long cnic = Convert.ToInt64(CNIC);
            ListsDLUser.getListOfAdminandManager()[0].Name = Name;
            ListsDLUser.getListOfAdminandManager()[0].Email = Email;
            ListsDLUser.getListOfAdminandManager()[0].Password = password;
            ListsDLUser.getListOfAdminandManager()[0].PhoneNo = phNO;
            ListsDLUser.getListOfAdminandManager()[0].CNIC = cnic;
            ListsDLUser.getListOfAdminandManager()[0].Address = address;
            ListsDLUser.signUp_File("SignIn_SignUp.txt",Email,password,Name,address,phNO,cnic);
            MessageBox.Show("Admin Updated Successfully!!!");
            this.Hide();
            AdminForm aF = new AdminForm();
            aF.Show();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            AdminForm aF = new AdminForm();
            aF.Show();
            this.Hide();
        }

        private void AdminUpdate_Load(object sender, EventArgs e)
        {
            NameBox.Text = ListsDLUser.getListOfAdminandManager()[0].Name;
            EmailBox.Text = ListsDLUser.getListOfAdminandManager()[0].Email;
            PasswordBox.Text = ListsDLUser.getListOfAdminandManager()[0].Password;
            PhoneNoBox.Text = ListsDLUser.getListOfAdminandManager()[0].PhoneNo.ToString();
            CNICBox.Text = ListsDLUser.getListOfAdminandManager()[0].CNIC.ToString();
            AddressBox.Text = ListsDLUser.getListOfAdminandManager()[0].Address;
        }
    }
}
