using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddBookk
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void addBookToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }

        private void editBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditBook EDIT = new EditBook();
            EDIT.Show();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnBook b = new ReturnBook();
            b.Show();
        }

        private void viewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewBookscs v = new ViewBookscs();
            v.Show();
        }

        private void deleteBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteBook b = new DeleteBook();
            b.Show();
        }

        private void eXITToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void borrowBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BorrowBook s = new BorrowBook();
            s.Show();
        }
    }
}
