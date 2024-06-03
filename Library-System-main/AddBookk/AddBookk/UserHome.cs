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
    public partial class UserHome : Form
    {
        public UserHome()
        {
            InitializeComponent();
        }

        private void viewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewBookscs v = new ViewBookscs();
            v.Show();
        }

        private void borrowBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BorrowBook s = new BorrowBook();
            s.Show();
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnBook b = new ReturnBook();
            b.Show();

        }

        private void eXITToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
