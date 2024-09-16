using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManagementSystem
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            Customer cr = new Customer();
            cr.Show();

        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            Accounts at = new Accounts();
            at.Show();
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            Transaction tn = new Transaction();
            tn.Show();
        }

        private void btnLoan_Click(object sender, EventArgs e)
        {
            Loan ln = new Loan();
            ln.Show();
        }

        private void btnEmp_Click(object sender, EventArgs e)
        {
            Employees em = new Employees();
            em.Show();
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            Dashboard db = new Dashboard();
            db.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            this.Close();
            fm.Show();
        }
    }
}
