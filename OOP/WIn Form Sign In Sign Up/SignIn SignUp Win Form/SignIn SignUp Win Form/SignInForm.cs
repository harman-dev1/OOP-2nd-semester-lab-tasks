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
using BMS.BL;

namespace SignIn_SignUp_Win_Form
{
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
        }
        private void ClearDataFromForm()
        {
            emailtxt.Text = "";
            emailpasswordtxt.Text = "";
        }
        private void next_button_Click(object sender, EventArgs e)
        {
            
            
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void next_button_Click_1(object sender, EventArgs e)
        {
            CustomerDL.dailyAmount = 10000;
            CustomerDL.specificIndexForCustomer = 0;
            EmployeeDL.specificIndexForEmployee = 0;
            string email = emailtxt.Text;

            if (string.IsNullOrEmpty(emailtxt.Text.Trim()))
            {
                errorProviderEmail.SetError(emailtxt, "Email Is Required");
                return;
            }
            else
            {
                errorProviderEmail.SetError(emailtxt, string.Empty);
            }
            if (string.IsNullOrEmpty(emailpasswordtxt.Text.Trim()))
            {
                errorProviderEmail.SetError(emailpasswordtxt, "Password Is Required");
                return;
            }
            else
            {
                errorProviderEmail.SetError(emailpasswordtxt, string.Empty);
            }

            //while((string.IsNullOrEmpty(emailtxt.Text)))
            //{

            //    MessageBox.Show("Email Can not Empty ");
            //    return;
            //}
            string password = emailpasswordtxt.Text;

            string role = ListsDLUser.checkUser(email, password);
            role = role.ToUpper();
            if (role == "ADMIN")
            {
                MessageBox.Show("SignIn Successfully as Admin!!!");
                this.Hide();
                AdminForm a = new AdminForm();
                a.Show();
            }
            else if (role == "EMPLOYEE")
            {
                MessageBox.Show("SignIn Successfully as Employee!!!");
                this.Hide();
                EmployeeMenu em = new EmployeeMenu();
                em.Show();
            }
            else if (role == "CUSTOMER")
            {
                CustomerMenu cM = new CustomerMenu();
                cM.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("User Not Found !!!");
            }
            ClearDataFromForm();
        }
        private void back_button_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void emailtxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
