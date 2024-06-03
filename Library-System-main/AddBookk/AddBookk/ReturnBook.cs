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
    public partial class ReturnBook : Form
    {
        public ReturnBook()
        {
            InitializeComponent();
        }

        private void search_Click(object sender, EventArgs e)
        {
            SqlConnection search = new SqlConnection();
            search.ConnectionString = "data source=NADOOSH\\Nada; database=LibrarySystem; integrated security=true";
            search.Open();
            String q1 = $"select* from books \r\nwhere title like '%{book.Text}%'";
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

        private void ReturnBook_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        string bname;
        Int64 id;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                id = Int64.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                bname = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            textBox1.Text = bname;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            SqlConnection search = new SqlConnection();
            search.ConnectionString = "data source=NADOOSH\\Nada; database=LibrarySystem; integrated security=true";
            search.Open();
            String q1 = $"update books\r\nset CopiesNo=CopiesNo+1\r\nwhere title='{textBox1.Text}'";
            SqlCommand cmd1 = new SqlCommand(q1, search);
            SqlDataReader sqlDataReader2 = cmd1.ExecuteReader();
            search.Close();
            search.Open();
            String q2 = $"update Members \r\nset NoBorrowBooks=NoBorrowBooks-1\r\nwhere ID={box.Text}";
            SqlCommand cmd2 = new SqlCommand(q2, search);
            SqlDataReader sqlDataReader3 = cmd2.ExecuteReader();
            search.Close();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
