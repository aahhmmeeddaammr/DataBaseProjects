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
    public partial class SignUP : Form
    {
        String Role = "Member";
        public SignUP()
        {
            InitializeComponent();
        }

        private void SignUP_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox9.Text == "" || textBox9.Text == "Email...") || (textBox1.Text == "" || textBox1.Text == "First Name...") || (textBox4.Text == "" || textBox4.Text == "City...") || (textBox3.Text == "" || textBox3.Text == "Street...") || (textBox6.Text == "" || textBox6.Text == "Password...") || (textBox5.Text != textBox6.Text || textBox5.Text == "" || textBox5.Text == "RePassword...") || (textBox8.Text == "major..." || textBox8.Text == "" || textBox8.Text == "Position...") || (textBox7.Text == "" || textBox7.Text == "UNI NAME..." || textBox7.Text == "Salary..."))
            {
                Validation.Text = "INVALID DATA";
                Validation.Visible = true;
                Validation.BackColor = Color.Red;
            }
            else
            {

                SqlConnection Signup = new SqlConnection();
                Signup.ConnectionString = "data source=NADOOSH\\Nada; database=LibrarySystem; integrated security=true ";
                String Q1;
                try
                {
                    Signup.Open();
                    if (Role == "Admin")
                    {
                        Q1 = $"insert into Admins\r\nvalues('{textBox9.Text}','{textBox6.Text}','{textBox1.Text}','{textBox2.Text}','{textBox4.Text}','{textBox3.Text}','{textBox7.Text}',{textBox8.Text})";
                    }
                    else
                    {
                        Q1 = $"insert into Members\r\nvalues('{textBox9.Text}','{textBox6.Text}','{textBox1.Text}','{textBox2.Text}','{textBox4.Text}','{textBox3.Text}',0,'{textBox8.Text}','{textBox7.Text}')";
                    }
                    SqlCommand cmd1 = new SqlCommand(Q1, Signup);
                    SqlDataReader sqlDataReader1 = cmd1.ExecuteReader();
                    Validation.Text = "SignUp Successfully";
                    Validation.Visible = true;
                    Validation.BackColor = Color.Green;
                    SignIn s = new SignIn();
                    s.Show(); 
                }
                catch (Exception ex)
                {
                    Validation.Text = "INVALID DATA";
                    Validation.Visible = true;
                    Validation.BackColor = Color.Red;

                }

                Signup.Close();
            }
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox1.Text == "First name...")
            {
                textBox1.Clear();
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox9.Text == "Email...")
            {
                textBox9.Clear();
            }
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox2.Text == "Last Name..")
            {
                textBox2.Clear();

            }
        }

        private void textBox4_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox4.Text == "City...")
            {
                textBox4.Clear();
            }
        }

        private void textBox3_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox3.Text == "Street...")
            {
                textBox3.Clear();
            }
        }

        private void textBox6_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox6.Text == "Password...")
            {
                textBox6.PasswordChar = '*';
                textBox6.Clear();
            }
        }

        private void textBox5_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox5.Text == "RePassword...")
            {
                textBox5.PasswordChar = '*';
                textBox5.Clear();
            }
        }

        private void textBox8_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox8.Text == "Major..." || textBox8.Text == "Salary...")
            {
                textBox8.Clear();
            }
        }

        private void textBox7_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox7.Text == "UNI NAME..." || textBox7.Text == "Position...")
            {
                textBox7.Clear();
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Role = "Admin";
            textBox8.Text = "Salary...";
            textBox7.Text = "Position...";
        }
    }
}
