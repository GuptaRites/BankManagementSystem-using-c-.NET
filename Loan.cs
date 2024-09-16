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
    public partial class Loan : Form
    {
        public Loan()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\.NET PROJECT\\BankManagementSystem\\Database1.mdf\";Integrated Security=True");
            conn.Open();

            SqlCommand cmd = new SqlCommand("insert into Loans values(@loan_id, @loan_Type, @amount, @interest_rate, @customer_name, @loan_Date)", conn);

            cmd.Parameters.AddWithValue("@loan_ID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@loan_Type", textBox2.Text);
            cmd.Parameters.AddWithValue("@amount", int.Parse(textBox3.Text));
            cmd.Parameters.AddWithValue("@interest_rate", textBox4.Text);
            cmd.Parameters.AddWithValue("@customer_name", textBox5.Text);
            cmd.Parameters.AddWithValue("@loan_Date", dateTimePicker1.Value);

            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Record Saved Successfully!");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\.NET PROJECT\\BankManagementSystem\\Database1.mdf\";Integrated Security=True");
            conn.Open();

            SqlCommand cmd = new SqlCommand("select * from Loans", conn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\.NET PROJECT\\BankManagementSystem\\Database1.mdf\";Integrated Security=True");
            conn.Open();

            SqlCommand cmd = new SqlCommand("update loans set loan_type=@loan_Type, amount=@amount, interest_rate=@interest_rate,  customer_name=@customer_name, loan_date=@loan_Date where loan_id=@loan_id", conn);

            cmd.Parameters.AddWithValue("@loan_ID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@loan_Type", textBox2.Text);
            cmd.Parameters.AddWithValue("@amount", int.Parse(textBox3.Text));
            cmd.Parameters.AddWithValue("@interest_rate", textBox4.Text);
            cmd.Parameters.AddWithValue("@customer_name", textBox5.Text);
            cmd.Parameters.AddWithValue("@loan_Date", dateTimePicker1.Value);

            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Record Updated Successfully!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\.NET PROJECT\\BankManagementSystem\\Database1.mdf\";Integrated Security=True");
            conn.Open();

            SqlCommand cmd = new SqlCommand("delete Loans where loan_id = @loan_id", conn);

            cmd.Parameters.AddWithValue("@loan_id", int.Parse(textBox1.Text));


            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Record deleted Successfully!");
        }

        private void Loan_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\.NET PROJECT\\BankManagementSystem\\Database1.mdf\";Integrated Security=True");
            conn.Open();

            SqlCommand cmd = new SqlCommand("select * from loans ", conn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
