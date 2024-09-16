namespace BankManagementSystem
{
    partial class Main
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            btnLogOut = new Button();
            btnEmp = new Button();
            btnAccount = new Button();
            btnTransaction = new Button();
            btnLoan = new Button();
            btnCustomer = new Button();
            btnDash = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1016, 93);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(761, 74);
            label1.TabIndex = 0;
            label1.Text = "Bank Management System";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 192, 255);
            panel2.Controls.Add(btnLogOut);
            panel2.Controls.Add(btnEmp);
            panel2.Controls.Add(btnAccount);
            panel2.Controls.Add(btnTransaction);
            panel2.Controls.Add(btnLoan);
            panel2.Controls.Add(btnCustomer);
            panel2.Controls.Add(btnDash);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 93);
            panel2.Name = "panel2";
            panel2.Size = new Size(251, 533);
            panel2.TabIndex = 1;
            // 
            // btnLogOut
            // 
            btnLogOut.Location = new Point(12, 475);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(230, 46);
            btnLogOut.TabIndex = 8;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnEmp
            // 
            btnEmp.Location = new Point(12, 196);
            btnEmp.Name = "btnEmp";
            btnEmp.Size = new Size(230, 46);
            btnEmp.TabIndex = 3;
            btnEmp.Text = "Employee";
            btnEmp.UseVisualStyleBackColor = true;
            btnEmp.Click += btnEmp_Click;
            // 
            // btnAccount
            // 
            btnAccount.Location = new Point(12, 251);
            btnAccount.Name = "btnAccount";
            btnAccount.Size = new Size(230, 46);
            btnAccount.TabIndex = 4;
            btnAccount.Text = "Account";
            btnAccount.UseVisualStyleBackColor = true;
            btnAccount.Click += btnAccount_Click;
            // 
            // btnTransaction
            // 
            btnTransaction.Location = new Point(12, 306);
            btnTransaction.Name = "btnTransaction";
            btnTransaction.Size = new Size(230, 46);
            btnTransaction.TabIndex = 5;
            btnTransaction.Text = "Transaction";
            btnTransaction.UseVisualStyleBackColor = true;
            btnTransaction.Click += btnTransaction_Click;
            // 
            // btnLoan
            // 
            btnLoan.Location = new Point(12, 363);
            btnLoan.Name = "btnLoan";
            btnLoan.Size = new Size(230, 46);
            btnLoan.TabIndex = 6;
            btnLoan.Text = "Loan";
            btnLoan.UseVisualStyleBackColor = true;
            btnLoan.Click += btnLoan_Click;
            // 
            // btnCustomer
            // 
            btnCustomer.Location = new Point(12, 419);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(230, 46);
            btnCustomer.TabIndex = 7;
            btnCustomer.Text = "Customer";
            btnCustomer.UseVisualStyleBackColor = true;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // btnDash
            // 
            btnDash.Location = new Point(12, 141);
            btnDash.Name = "btnDash";
            btnDash.Size = new Size(230, 46);
            btnDash.TabIndex = 2;
            btnDash.Text = "Dashboard";
            btnDash.UseVisualStyleBackColor = true;
            btnDash.Click += btnDash_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.ABA_bank;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(12, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(230, 114);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1016, 626);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Main";
            Text = "Main";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Button btnEmp;
        private Button btnAccount;
        private Button btnTransaction;
        private Button btnLoan;
        private Button btnCustomer;
        private Button btnDash;
        private PictureBox pictureBox1;
        private Button btnLogOut;
    }
}