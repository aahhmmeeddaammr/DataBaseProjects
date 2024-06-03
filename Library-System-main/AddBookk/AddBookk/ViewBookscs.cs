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
    public partial class ViewBookscs : Form
    {
        public ViewBookscs()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ViewBookscs_Load(object sender, EventArgs e)
        {
            SqlConnection search = new SqlConnection();
            search.ConnectionString = "data source=NADOOSH\\Nada; database=LibrarySystem; integrated security=true";
            search.Open();
            String q1 = $"select* from books";
            SqlCommand cmd1 = new SqlCommand(q1, search);
            SqlDataReader sqlDataReader2 = cmd1.ExecuteReader();
            SqlDataAdapter d = new SqlDataAdapter(cmd1);
            search.Close();
            search.Open();
            DataSet ds = new DataSet();
            d.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            search.Close();
        }

        private void view_Click(object sender, EventArgs e)
        {
            SqlConnection search = new SqlConnection();
            search.ConnectionString = "data source=NADOOSH\\Nada; database=LibrarySystem; integrated security=true";
            search.Open();
            String q1 = $"select* from books \r\nwhere title like '%{name.Text}%'";
            SqlCommand cmd1 = new SqlCommand(q1, search);
            SqlDataReader sqlDataReader2 = cmd1.ExecuteReader();
            SqlDataAdapter d = new SqlDataAdapter(cmd1);
            search.Close();
            search.Open();
            DataSet ds = new DataSet();
            d.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            search.Close();
        }
    }
}
