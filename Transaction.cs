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
    public partial class Transaction : Form
    {
        public Transaction()
        {
            InitializeComponent();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\.NET PROJECT\\BankManagementSystem\\Database1.mdf\";Integrated Security=True");
            conn.Open();

            SqlCommand cmd = new SqlCommand("insert into transactions values(@transaction_id, @transaction_Type, @amount, @transaction_Date, @account_id)", conn);

            cmd.Parameters.AddWithValue("@transaction_ID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@transaction_Type", textBox2.Text);
            cmd.Parameters.AddWithValue("@amount", int.Parse(textBox3.Text));
            cmd.Parameters.AddWithValue("@transaction_Date", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@account_id", int.Parse(textBox5.Text));

            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Record Saved Successfully!");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\.NET PROJECT\\BankManagementSystem\\Database1.mdf\";Integrated Security=True");
            conn.Open();

            SqlCommand cmd = new SqlCommand("select *from transactions", conn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\.NET PROJECT\\BankManagementSystem\\Database1.mdf\";Integrated Security=True");
            conn.Open();

            SqlCommand cmd = new SqlCommand("update transactions set transaction_type=@transaction_Type, amount=@amount, @transaction_date=@transaction_Date, account_id=@account_id where transaction_id=@transaction_id", conn);

            cmd.Parameters.AddWithValue("@transaction_ID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@transaction_Type", textBox2.Text);
            cmd.Parameters.AddWithValue("@amount", int.Parse(textBox3.Text));
            cmd.Parameters.AddWithValue("@transaction_Date", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@account_id", int.Parse(textBox5.Text));

            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Record Updated Successfully!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\.NET PROJECT\\BankManagementSystem\\Database1.mdf\";Integrated Security=True");
            conn.Open();

            SqlCommand cmd = new SqlCommand("delete transactions where transaction_id = @transaction_id", conn);

            cmd.Parameters.AddWithValue("@transaction_id", int.Parse(textBox1.Text));


            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Record deleted Successfully!");
        }

        private void Transaction_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\.NET PROJECT\\BankManagementSystem\\Database1.mdf\";Integrated Security=True");
            conn.Open();

            SqlCommand cmd = new SqlCommand("select *from transactions", conn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
