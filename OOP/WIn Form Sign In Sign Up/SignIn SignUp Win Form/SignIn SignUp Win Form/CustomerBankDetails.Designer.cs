
namespace SignIn_SignUp_Win_Form
{
    partial class CustomerBankDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BankName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BankEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BankBranchID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BankAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BankNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(314, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Bank Details";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BankName,
            this.BankEmail,
            this.BankBranchID,
            this.BankAddress,
            this.BankNo});
            this.dataGridView1.Location = new System.Drawing.Point(125, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(556, 80);
            this.dataGridView1.TabIndex = 7;
            // 
            // BankName
            // 
            this.BankName.HeaderText = "Bank Name";
            this.BankName.Name = "BankName";
            this.BankName.ReadOnly = true;
            // 
            // BankEmail
            // 
            this.BankEmail.HeaderText = "Bank Email";
            this.BankEmail.Name = "BankEmail";
            this.BankEmail.ReadOnly = true;
            // 
            // BankBranchID
            // 
            this.BankBranchID.HeaderText = "Bank Branch ID";
            this.BankBranchID.Name = "BankBranchID";
            this.BankBranchID.ReadOnly = true;
            // 
            // BankAddress
            // 
            this.BankAddress.HeaderText = "Bank Address";
            this.BankAddress.Name = "BankAddress";
            this.BankAddress.ReadOnly = true;
            // 
            // BankNo
            // 
            this.BankNo.HeaderText = "Bank Telephone";
            this.BankNo.Name = "BankNo";
            this.BankNo.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(345, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "Back To Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CustomerBankDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerBankDetails";
            this.Text = "CustomerBankDetails";
            this.Load += new System.EventHandler(this.CustomerBankDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BankName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BankEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn BankBranchID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BankAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn BankNo;
        private System.Windows.Forms.Button button1;
    }
}