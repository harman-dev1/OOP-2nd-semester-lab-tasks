
namespace SignIn_SignUp_Win_Form
{
    partial class BankData
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BankName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BankEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BankAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BankNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BankID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Money = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.Backbtt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BankName,
            this.BankEmail,
            this.BankAddress,
            this.BankNO,
            this.BankID,
            this.Money});
            this.dataGridView1.Location = new System.Drawing.Point(117, 160);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 132);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BankName
            // 
            this.BankName.HeaderText = "Bank Name";
            this.BankName.Name = "BankName";
            // 
            // BankEmail
            // 
            this.BankEmail.HeaderText = "Bank Email";
            this.BankEmail.Name = "BankEmail";
            // 
            // BankAddress
            // 
            this.BankAddress.HeaderText = "Bank Address";
            this.BankAddress.Name = "BankAddress";
            // 
            // BankNO
            // 
            this.BankNO.HeaderText = "Bank No";
            this.BankNO.Name = "BankNO";
            // 
            // BankID
            // 
            this.BankID.HeaderText = "BankID";
            this.BankID.Name = "BankID";
            // 
            // Money
            // 
            this.Money.HeaderText = "Bank Money For Loan";
            this.Money.Name = "Money";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGray;
            this.label6.Location = new System.Drawing.Point(251, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(254, 27);
            this.label6.TabIndex = 15;
            this.label6.Text = "Bank Management Syestm";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Backbtt
            // 
            this.Backbtt.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backbtt.Location = new System.Drawing.Point(362, 378);
            this.Backbtt.Name = "Backbtt";
            this.Backbtt.Size = new System.Drawing.Size(129, 34);
            this.Backbtt.TabIndex = 16;
            this.Backbtt.Text = "Back To Menu";
            this.Backbtt.UseVisualStyleBackColor = true;
            this.Backbtt.Click += new System.EventHandler(this.Backbtt_Click);
            // 
            // BankData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Backbtt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BankData";
            this.Text = "BankData";
            this.Load += new System.EventHandler(this.BankData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Backbtt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BankName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BankEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn BankAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn BankNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn BankID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Money;
    }
}