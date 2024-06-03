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
namespace AddBookk
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection login = new SqlConnection();
            login.ConnectionString = "data source=NADOOSH\\Nada; database=LibrarySystem; integrated security=true";
            login.Open();
            string sqlQuery1 = $"select* from Admins where Password='{textBox2.Text}' and Email='{textBox1.Text}'";
            string sqlQuery2 = $"select* from Members where Password='{textBox2.Text}' and Email='{textBox1.Text}'";
            bool done = false;
            SqlCommand cmd1 = new SqlCommand(sqlQuery1, login);
            SqlDataReader sqlDataReader1 = cmd1.ExecuteReader();
            if (sqlDataReader1.HasRows)
            {

                textBox3.BackColor = Color.Green;
                textBox3.ForeColor = Color.White;
                textBox3.Visible = true;
                textBox3.Text = "LogIn Successfully";
                Home h = new Home();
                h.Show();
                return;
            }
            sqlDataReader1.Close();
            login.Close();
            login.Open();
            SqlCommand cmd2 = new SqlCommand(sqlQuery2, login);
            SqlDataReader sqlDataReader2 = cmd2.ExecuteReader();
            if (sqlDataReader2.HasRows)
            {
                textBox3.BackColor = Color.Green;
                textBox3.ForeColor = Color.White;
                textBox3.Visible = true;
                textBox3.Text = "LogIn Successfully";
                UserHome h = new UserHome();
                h.Show();
                return;
            }
            else
            {
                textBox3.BackColor = Color.Red;
                textBox3.ForeColor = Color.White;
                textBox3.Visible = true;
                textBox3.Text = "inCorrect Email Or Password";
            }
            login.Close();
            sqlDataReader2.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SignUP s = new SignUP();
            s.Show();
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox1.Text == "USER Email...")
            {
                textBox1.Clear();
                panel1.BackColor = Color.DarkGreen;
            }
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox2.Text == "Password...")
            {
                textBox2.Clear();
                textBox2.PasswordChar = '*';
                panel3.BackColor = Color.DarkGreen;
            }
        }
    }
}
