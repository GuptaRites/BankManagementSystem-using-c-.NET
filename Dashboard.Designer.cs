namespace BankManagementSystem
{
    partial class Dashboard
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
            l1 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            l2 = new Label();
            label3 = new Label();
            panel4 = new Panel();
            l3 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1095, 87);
            panel1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(301, 9);
            label1.Name = "label1";
            label1.Size = new Size(488, 54);
            label1.TabIndex = 0;
            label1.Text = "ABA BANK DASHBOARD";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 255, 192);
            panel2.Controls.Add(l1);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(56, 124);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 150);
            panel2.TabIndex = 8;
            // 
            // l1
            // 
            l1.AutoSize = true;
            l1.BackColor = Color.White;
            l1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            l1.Location = new Point(120, 78);
            l1.Name = "l1";
            l1.Size = new Size(33, 38);
            l1.TabIndex = 1;
            l1.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(36, 18);
            label2.Name = "label2";
            label2.Size = new Size(227, 38);
            label2.TabIndex = 0;
            label2.Text = "Total Customers";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(192, 255, 192);
            panel3.Controls.Add(l2);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(667, 124);
            panel3.Name = "panel3";
            panel3.Size = new Size(300, 150);
            panel3.TabIndex = 9;
            // 
            // l2
            // 
            l2.AutoSize = true;
            l2.BackColor = Color.White;
            l2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            l2.Location = new Point(126, 78);
            l2.Name = "l2";
            l2.Size = new Size(33, 38);
            l2.TabIndex = 2;
            l2.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(67, 18);
            label3.Name = "label3";
            label3.Size = new Size(164, 38);
            label3.TabIndex = 1;
            label3.Text = "Total Loans";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(192, 255, 192);
            panel4.Controls.Add(l3);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(363, 346);
            panel4.Name = "panel4";
            panel4.Size = new Size(300, 150);
            panel4.TabIndex = 10;
            // 
            // l3
            // 
            l3.AutoSize = true;
            l3.BackColor = Color.White;
            l3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            l3.Location = new Point(133, 72);
            l3.Name = "l3";
            l3.Size = new Size(33, 38);
            l3.TabIndex = 2;
            l3.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(37, 17);
            label4.Name = "label4";
            label4.Size = new Size(229, 38);
            label4.TabIndex = 1;
            label4.Text = "Total Employees";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1095, 578);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Panel panel3;
        private Panel panel4;
        private Label l1;
        private Label l2;
        private Label label3;
        private Label l3;
        private Label label4;
    }
}