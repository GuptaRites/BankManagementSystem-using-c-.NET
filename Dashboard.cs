using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManagementSystem
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

       // private void label7_Click(object sender, EventArgs e)
       // {

        //}


        private void Dashboard_Load(object sender, EventArgs e)
        {
            display();
            display1();
            display2();
        }
        private void display()
        {

            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\.NET PROJECT\\BankManagementSystem\\Database1.mdf\";Integrated Security=True");
            conn.Open();

            SqlCommand cmd = new SqlCommand("select count(*) from customers", conn);
            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)
            {
                l1.Text = Convert.ToString(count.ToString());
            }
            else
            {
                l1.Text = "0";
            }

            conn.Close();
        }
        private void display1()
        {

            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\.NET PROJECT\\BankManagementSystem\\Database1.mdf\";Integrated Security=True");
            conn.Open();

            SqlCommand cmd = new SqlCommand("select count(*) from loans", conn);
            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)
            {
                l2.Text = Convert.ToString(count.ToString());
            }
            else
            {
                l2.Text = "0";
            }

            conn.Close();
        }
        private void display2()
        {

            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\.NET PROJECT\\BankManagementSystem\\Database1.mdf\";Integrated Security=True");
            conn.Open();

            SqlCommand cmd = new SqlCommand("select count(*) from employees", conn);
            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)
            {
                l3.Text = Convert.ToString(count.ToString());
            }
            else
            {
                l3.Text = "0";
            }

            conn.Close();
        }
    }
}
