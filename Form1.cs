using System.Data;
using System.Data.SqlClient;


namespace BankManagementSystem
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }


        private void btnlogin_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\.NET PROJECT\\BankManagementSystem\\Database1.mdf\";Integrated Security=True");
            string query = "select username, password from login where username='" + txtusername.Text + "'and password='" + txtpassword.Text+"'";

            string uname = txtusername.Text;
            string password = txtpassword.Text;

            conn.Open();

            SqlCommand cmd = new SqlCommand(query, conn);

            //cmd.Parameters.AddWithValue("@uname", txtusername.Text);
            //cmd.Parameters.AddWithValue("@password", txtpassword.Text);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);

            if (dt.Rows.Count > 0 )
            {
                Main mn = new Main();
                mn.Show();
            }
            else {
                MessageBox.Show("Login Failed!! Please check Username and password.");

            }
            conn.Close();

        }
    }
}
