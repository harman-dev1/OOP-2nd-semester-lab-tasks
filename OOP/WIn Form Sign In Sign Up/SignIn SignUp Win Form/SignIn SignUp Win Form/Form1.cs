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
using System.Drawing.Drawing2D;

using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SignIn_SignUp_Win_Form
{
    public partial class Form1 : Form
    {
        private Rectangle buttonOriginalrectangle;
        private Rectangle originalFormSize;
        public Form1()
        {
            InitializeComponent();
            ListsDLUser.loadAdminData();
            CustomerDL.loadCustomersData();
            EmployeeDL.loadEmployeeData();
            ListsDLUser.load_bank_data();
            ApplyRoundedRegion(this);
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            if(ListsDLUser.getListCount() == 0)
            {
                this.Hide();
                MenuForm signUp = new MenuForm();
                signUp.Show();
            }
            else
            {
                MessageBox.Show("Admin Already SignUp !!!");
            }
        }

        private void txt_UserEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //originalFormSize = this.Size;
            //buttonOriginalrectangle = new Rectangle(button_SignIn.Location.X);
        }

        private void button_SignIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignInForm s = new SignInForm();
            s.Show();   
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ApplyRoundedRegion(Form form)
        {
            GraphicsPath path = new GraphicsPath();
            int radius = 20; // Adjust this value to change the rounding radius

            // Create a rounded rectangle path
            Rectangle rect = new Rectangle(0, 0, form.Width, form.Height);
            path.AddArc(rect.X, rect.Y, radius * 2, radius * 2, 180, 90);
            path.AddLine(rect.X + radius, rect.Y, rect.Right - radius * 2, rect.Y);
            path.AddArc(rect.X + rect.Width - radius * 2, rect.Y, radius * 2, radius * 2, 270, 90);
            path.AddLine(rect.Right, rect.Y + radius * 2, rect.Right, rect.Bottom - radius * 2);
            path.AddArc(rect.X + rect.Width - radius * 2, rect.Y + rect.Height - radius * 2, radius * 2, radius * 2, 0, 90);
            path.AddLine(rect.Right - radius * 2, rect.Bottom, rect.X + radius * 2, rect.Bottom);
             path.AddArc(rect.X, rect.Y + rect.Height - radius * 2, radius * 2, radius * 2, 90, 90);
            path.AddLine(rect.X, rect.Bottom - radius * 2, rect.X, rect.Y + radius * 2);

            form.Region = new Region(path);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
