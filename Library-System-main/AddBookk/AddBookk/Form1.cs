using System.Data.SqlClient;
namespace AddBookk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection add = new SqlConnection();
            add.ConnectionString = "data source=NADOOSH\\Nada; database=LibrarySystem; integrated security=true";
            add.Open();
            String q1 = $"select isbn \r\nfrom books\r\nwhere isbn={isbn.Text}";
            SqlCommand cmd1 = new SqlCommand(q1, add);
            SqlDataReader sqlDataReader2 = cmd1.ExecuteReader();
            if (sqlDataReader2.HasRows)
            {
                add.Close();
                add.Open();
                String qq = $"update books \r\nset CopiesNo=CopiesNo+1\r\nwhere isbn={isbn.Text}";
                String q2 = $"insert into Copies\r\nvalues('{title.Text}',1,{isbn.Text})";
                SqlCommand cmd2 = new SqlCommand(qq, add);
                SqlDataReader sqlDataReader3 = cmd2.ExecuteReader();
                add.Close();
                add.Open();
                SqlCommand cmdd = new SqlCommand(q2, add);
                SqlDataReader sqlDataReaderr = cmdd.ExecuteReader();
            }
            else
            {
                add.Close();
                add.Open();
                String q = $"insert into Books\r\nvalues({isbn.Text},'{title.Text}',{price.Text},'{sum.Text}',{pyear.Text},{ed.Text},0,{aid.Text},{cid.Text})";
                SqlCommand cmd3 = new SqlCommand(q, add);
                SqlDataReader sqlDataReader = cmd3.ExecuteReader();
                add.Close();
                add.Open();
                String qs = $"insert into copies\r\nvalues('{title.Text}',1,{isbn.Text})";
                SqlCommand cmdd = new SqlCommand(qs, add);
                SqlDataReader sqlDataReaderr = cmdd.ExecuteReader();
            }
            add.Close();


        }

        private void isbn_MouseClick(object sender, MouseEventArgs e)
        {
            if (isbn.Text == "ISBN...")
            {
                isbn.Clear();
            }
        }

        private void title_MouseClick(object sender, MouseEventArgs e)
        {
            if (title.Text == "Title...")
            {
                title.Clear();
            }
        }

        private void price_MouseClick(object sender, MouseEventArgs e)
        {

            if (price.Text == "price...")
            {
                price.Clear();
            }

        }

        private void sum_MouseClick(object sender, MouseEventArgs e)
        {
            if (sum.Text == "summary")
            {
                sum.Clear();
            }

        }

        private void pyear_MouseClick(object sender, MouseEventArgs e)
        {
            if (pyear.Text == "publication year...")
            {
                pyear.Clear();
            }
        }

        private void ed_MouseClick(object sender, MouseEventArgs e)
        {
            if (ed.Text == "edition...")
            {
                ed.Clear();
            }
        }



        private void aid_MouseClick(object sender, MouseEventArgs e)
        {
            if (aid.Text == "auther id...")
            {
                aid.Clear();
            }
        }

        private void cid_MouseClick(object sender, MouseEventArgs e)
        {
            if (cid.Text == "category id...")
            {
                cid.Clear();
            }
        }

        private void pyear_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
