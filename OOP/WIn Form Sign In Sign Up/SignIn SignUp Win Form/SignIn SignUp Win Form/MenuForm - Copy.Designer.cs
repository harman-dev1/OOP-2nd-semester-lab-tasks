
namespace SignIn_SignUp_Win_Form
{
    partial class MenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.passwortxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addresstxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.phnotxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cnictxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.next_button = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.back_button = new System.Windows.Forms.Button();
            this.errorProviderEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderEmailPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderAddress = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPhonNo = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderCNIC = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmailPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPhonNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCNIC)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // emailtxt
            // 
            this.emailtxt.Location = new System.Drawing.Point(330, 100);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(210, 20);
            this.emailtxt.TabIndex = 1;
            this.emailtxt.TextChanged += new System.EventHandler(this.emailtxt_TextChanged);
            // 
            // passwortxt
            // 
            this.passwortxt.Location = new System.Drawing.Point(330, 153);
            this.passwortxt.MaxLength = 7;
            this.passwortxt.Name = "passwortxt";
            this.passwortxt.Size = new System.Drawing.Size(210, 20);
            this.passwortxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email Password (1-->7 Characters)";
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(330, 202);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(210, 20);
            this.nametxt.TabIndex = 5;
            this.nametxt.TextChanged += new System.EventHandler(this.Name_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(90, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name";
            // 
            // addresstxt
            // 
            this.addresstxt.Location = new System.Drawing.Point(330, 250);
            this.addresstxt.Name = "addresstxt";
            this.addresstxt.Size = new System.Drawing.Size(210, 20);
            this.addresstxt.TabIndex = 7;
            this.addresstxt.TextChanged += new System.EventHandler(this.addresstxt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(90, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Address";
            // 
            // phnotxt
            // 
            this.phnotxt.Location = new System.Drawing.Point(330, 300);
            this.phnotxt.MaxLength = 11;
            this.phnotxt.Name = "phnotxt";
            this.phnotxt.Size = new System.Drawing.Size(210, 20);
            this.phnotxt.TabIndex = 9;
            this.phnotxt.TextChanged += new System.EventHandler(this.phnotxt_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(90, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Phone No (1-->11 Characters)";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // cnictxt
            // 
            this.cnictxt.Location = new System.Drawing.Point(330, 343);
            this.cnictxt.MaxLength = 13;
            this.cnictxt.Name = "cnictxt";
            this.cnictxt.Size = new System.Drawing.Size(210, 20);
            this.cnictxt.TabIndex = 11;
            this.cnictxt.TextChanged += new System.EventHandler(this.cnictxt_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(90, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "CNIC (1-->13 Characters)";
            // 
            // next_button
            // 
            this.next_button.BackColor = System.Drawing.SystemColors.HotTrack;
            this.next_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.next_button.Location = new System.Drawing.Point(541, 388);
            this.next_button.Name = "next_button";
            this.next_button.Size = new System.Drawing.Size(120, 41);
            this.next_button.TabIndex = 12;
            this.next_button.Text = "Next";
            this.next_button.UseVisualStyleBackColor = false;
            this.next_button.Click += new System.EventHandler(this.next_button_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(289, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "WellCome As Admin";
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.SystemColors.HotTrack;
            this.back_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.back_button.Location = new System.Drawing.Point(93, 388);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(120, 41);
            this.back_button.TabIndex = 14;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // errorProviderEmail
            // 
            this.errorProviderEmail.ContainerControl = this;
            // 
            // errorProviderEmailPassword
            // 
            this.errorProviderEmailPassword.ContainerControl = this;
            // 
            // errorProviderName
            // 
            this.errorProviderName.ContainerControl = this;
            // 
            // errorProviderAddress
            // 
            this.errorProviderAddress.ContainerControl = this;
            // 
            // errorProviderPhonNo
            // 
            this.errorProviderPhonNo.ContainerControl = this;
            // 
            // errorProviderCNIC
            // 
            this.errorProviderCNIC.ContainerControl = this;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.next_button);
            this.Controls.Add(this.cnictxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.phnotxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addresstxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passwortxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.emailtxt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuForm";
            this.Text = "SignIn Form";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmailPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPhonNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCNIC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox emailtxt;
        private System.Windows.Forms.TextBox passwortxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addresstxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox phnotxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cnictxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button next_button;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.ErrorProvider errorProviderEmail;
        private System.Windows.Forms.ErrorProvider errorProviderEmailPassword;
        private System.Windows.Forms.ErrorProvider errorProviderName;
        private System.Windows.Forms.ErrorProvider errorProviderAddress;
        private System.Windows.Forms.ErrorProvider errorProviderPhonNo;
        private System.Windows.Forms.ErrorProvider errorProviderCNIC;
    }
}