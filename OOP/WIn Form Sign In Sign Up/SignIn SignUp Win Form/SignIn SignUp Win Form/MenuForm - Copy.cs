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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void addresstxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void phnotxt_TextChanged(object sender, EventArgs e)
        {

        }
        private void cnictxt_TextChanged(object sender, EventArgs e)
        {

        }
        private void ClearDataFromForm()
        {
            emailtxt.Text = "";
            passwortxt.Text = "";
            nametxt.Text = "";
            addresstxt.Text = "";
            phnotxt.Text = "";
            cnictxt.Text = "";
        }
        private void next_button_Click(object sender, EventArgs e)
        {
            
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
            while ((ListsDLUser.checkEmail(email) == false))
            {

                MessageBox.Show("Email Is not in a Correct Format ");
                return;
            }

            string password = passwortxt.Text;
            if (string.IsNullOrEmpty(passwortxt.Text.Trim()))
            {
                errorProviderEmail.SetError(passwortxt, "Password Is Required");
                return;
            }
            else
            {
                errorProviderEmail.SetError(passwortxt, string.Empty);
            }

            string name = nametxt.Text;
            
           
            string address = addresstxt.Text;
            if (string.IsNullOrEmpty(addresstxt.Text.Trim()))
            {
                errorProviderEmail.SetError(addresstxt, "Address is Required");
                return;
            }
            else
            {
                errorProviderEmail.SetError(addresstxt, string.Empty);
            }

            string phoneNo = (phnotxt.Text);
            if (string.IsNullOrEmpty(phnotxt.Text.Trim()))
            {
                errorProviderEmail.SetError(phnotxt, "Phone No is Required");
                return;
            }
            else
            {
                errorProviderEmail.SetError(phnotxt, string.Empty);
            }
            while ((ListsDLUser.checkPhoneNo(Convert.ToInt64(phoneNo)) == false))
            {

                MessageBox.Show("length of PhNo 11 Digits and First digit is \"0\" as in Pakistan ");
                return;
            }
            long Phone_no = Convert.ToInt64(phoneNo);

            string CNIC = (cnictxt.Text);
            if (string.IsNullOrEmpty(cnictxt.Text.Trim()))
            {
                errorProviderEmail.SetError(cnictxt, "CNIC is Required");
                return;
            }
            else
            {
                errorProviderEmail.SetError(cnictxt, string.Empty);
            }
            while ((ListsDLUser.checkCNIC(Convert.ToInt64(CNIC)) == false))
            {

                MessageBox.Show("length of CNIC 13 Digits and First digit is \"3\" as in Pakistan ");
                return;
            }
            long c_n_I_C = Convert.ToInt64(CNIC);

            User u = new User(email,password,c_n_I_C,address,Phone_no,name);
            ListsDLUser.setList(u);
            string path = "SignIn_SignUp.txt";
            ListsDLUser.signUp_File(path, email, password, name, address, Phone_no, c_n_I_C);
            MessageBox.Show("Admin Added Successfully!!!");
            ClearDataFromForm();
            this.Close();
            Form1 f = new Form1();
            f.Show();
        }
        public bool isValidName(string n)
        {
            Regex check = new Regex(@"^([A-Z][a-z-A-z]+)$");
            bool valid = false;
            valid = check.IsMatch(n);
            if(valid == true)
            {
                return valid;
            }
            else
            {
                MessageBox.Show("Name Format is Not a Correct");
                return valid;
            }
        }
        private void back_button_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }
    }
}
