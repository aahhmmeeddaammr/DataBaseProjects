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
    public partial class EditBook : Form
    {
        public EditBook()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection edit = new SqlConnection();
            edit.ConnectionString = "data source=NADOOSH\\Nada; database=LibrarySystem; integrated security=true";
            edit.Open();
            String q = $"update books\r\nset price={price.Text},pyear={pyear.Text},title='{title.Text}',Summary='{sum.Text}',Edition={ed.Text},AuthorID={aid.Text},CatID={cid.Text}\r\nwhere isbn=22";
            SqlCommand cmd1 = new SqlCommand(q, edit);
            SqlDataReader sqlDataReader2 = cmd1.ExecuteReader();
            edit.Close();

        }

        
        private void isbn_MouseClick(object sender, MouseEventArgs e)
        {
            if (isbn.Text == "ISBN...")
            {
                isbn.Clear();
            }
        }

        private void isbn_TextChanged(object sender, EventArgs e)
        {

        }

        private void EditBook_Load(object sender, EventArgs e)
        {
            SqlConnection show = new SqlConnection();
            show.ConnectionString = "data source=NADOOSH\\Nada; database=LibrarySystem; integrated security=true";
            show.Open();
            String q = $"select *\r\nfrom books\r\nwhere isbn=22";
            SqlCommand cmd1 = new SqlCommand(q, show);
            SqlDataReader sqlDataReader2 = cmd1.ExecuteReader();
            if (sqlDataReader2.HasRows)
            {
                isbn.Text = "22";
                while (sqlDataReader2.Read())
                {
                    title.Text = sqlDataReader2["title"].ToString();
                    price.Text = sqlDataReader2["price"].ToString();
                    sum.Text = sqlDataReader2["summary"].ToString();
                    pyear.Text = sqlDataReader2["pyear"].ToString();
                    ed.Text = sqlDataReader2["edition"].ToString();
                    aid.Text = sqlDataReader2["AuthorID"].ToString();
                    cid.Text = sqlDataReader2["catid"].ToString();
                }
              

            }
            show.Close();

        }
    }
}
