using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BankManagementSystem
{
    public partial class Accounts : Form
    {
        public Accounts()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\.NET PROJECT\\BankManagementSystem\\Database1.mdf\";Integrated Security=True");
            conn.Open();

            SqlCommand cmd = new SqlCommand("insert into accounts values(@account_id, @Account_Type, @Balance, @Date_Opened, @customer_name)", conn);

            cmd.Parameters.AddWithValue("@Account_ID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Account_Type", textBox2.Text);
            cmd.Parameters.AddWithValue("@Balance", textBox3.Text);
            cmd.Parameters.AddWithValue("@Date_Opened", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@Customer_Name", textBox5.Text);

            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Record Saved Successfully!");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd/mm/yyyy";
        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                dateTimePicker1.CustomFormat = "";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\.NET PROJECT\\BankManagementSystem\\Database1.mdf\";Integrated Security=True");
            conn.Open();

            SqlCommand cmd = new SqlCommand("select *from accounts", conn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\.NET PROJECT\\BankManagementSystem\\Database1.mdf\";Integrated Security=True");
            conn.Open();

            SqlCommand cmd = new SqlCommand("Update accounts set account_type = @Account_Type, Balance=@Balance, date_opened=@Date_Opened, customer_name=@customer_name where account_id=@account_id", conn);

            cmd.Parameters.AddWithValue("@Account_ID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Account_Type", textBox2.Text);
            cmd.Parameters.AddWithValue("@Balance", textBox3.Text);
            cmd.Parameters.AddWithValue("@Date_Opened", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@Customer_Name", textBox5.Text);

            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Record Updated Successfully!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\.NET PROJECT\\BankManagementSystem\\Database1.mdf\";Integrated Security=True");
            conn.Open();

            SqlCommand cmd = new SqlCommand("delete accounts where account_id = @account_id", conn);

            cmd.Parameters.AddWithValue("@account_id", int.Parse(textBox1.Text));


            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Record deleted Successfully!");
        }

        private void Accounts_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\.NET PROJECT\\BankManagementSystem\\Database1.mdf\";Integrated Security=True");
            conn.Open();

            SqlCommand cmd = new SqlCommand("select *from accounts", conn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\.NET PROJECT\\BankManagementSystem\\Database1.mdf\";Integrated Security=True");
            conn.Open();

            SqlCommand cmd = new SqlCommand("select *from accounts where customer_name=@customer_name", conn);
            cmd.Parameters.AddWithValue("@Customer_Name", textBox6.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            dataGridView1.DataSource = dt;
        }
    }
}
