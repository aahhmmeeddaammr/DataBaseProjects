using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddBookk
{
    public partial class DeleteBook : Form
    {
        public DeleteBook()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection edit = new SqlConnection();
            edit.ConnectionString = "data source=NADOOSH\\Nada; database=LibrarySystem; integrated security=true";
            edit.Open();
            String q = $"delete from copies\r\nwhere BookID={id.Text}";
            SqlCommand cmd1 = new SqlCommand(q, edit);
            SqlDataReader sqlDataReader2 = cmd1.ExecuteReader();
            edit.Close();
            edit.Open();
            String q1 = $"delete from books\r\nwhere isbn={id.Text}";
            SqlCommand cmd2 = new SqlCommand(q1, edit);
            SqlDataReader sqlDataReader = cmd2.ExecuteReader();

        }
    }
}
