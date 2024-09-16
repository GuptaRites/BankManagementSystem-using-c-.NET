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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\.NET PROJECT\\BankManagementSystem\\Database1.mdf\";Integrated Security=True");
            conn.Open();

            SqlCommand cmd = new SqlCommand("insert into customers values(@customer_id, @customer_name, @phone, @email, @address)", conn);

            cmd.Parameters.AddWithValue("@customer_id", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@customer_name", textBox4.Text);
            cmd.Parameters.AddWithValue("@phone", textBox3.Text);
            cmd.Parameters.AddWithValue("@email", textBox2.Text);
            cmd.Parameters.AddWithValue("@address", textBox5.Text);

            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Record Saved Successfully!");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\.NET PROJECT\\BankManagementSystem\\Database1.mdf\";Integrated Security=True");
            conn.Open();

            SqlCommand cmd = new SqlCommand("select *from customers", conn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\.NET PROJECT\\BankManagementSystem\\Database1.mdf\";Integrated Security=True");
            conn.Open();

            SqlCommand cmd = new SqlCommand("update customers set customer_name=@customer_name, phone=@phone, email=@email, address=@address where customer_id= @customer_id", conn);

            cmd.Parameters.AddWithValue("@customer_id", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@customer_name", textBox4.Text);
            cmd.Parameters.AddWithValue("@phone", textBox3.Text);
            cmd.Parameters.AddWithValue("@email", textBox2.Text);
            cmd.Parameters.AddWithValue("@address", textBox5.Text);

            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Record Updated Successfully!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\.NET PROJECT\\BankManagementSystem\\Database1.mdf\";Integrated Security=True");
            conn.Open();

            SqlCommand cmd = new SqlCommand("delete customers where customer_id = @customer_id", conn);

            cmd.Parameters.AddWithValue("@customer_id", int.Parse(textBox1.Text));


            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Record deleted Successfully!");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Customer_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\.NET PROJECT\\BankManagementSystem\\Database1.mdf\";Integrated Security=True");
            conn.Open();

            SqlCommand cmd = new SqlCommand("select *from customers", conn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
