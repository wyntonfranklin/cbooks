using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CBooks
{
    public partial class Form1 : Form
    {
        List<Books> books = new List<Books>();

        public Form1()
        {
            InitializeComponent();
            Books bk = new Books("hello");
            books.Add(bk);
            booksList.DataSource = books;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
