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

        public Form1()
        {
            InitializeComponent();
            Books bk = new Books("hello");
            BookAdapter.AddBook(bk);
            booksList.DataSource = BookAdapter.GetAllBooks();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void booksList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Books bk = (Books)booksList.SelectedItem;
            Console.WriteLine(bk.title);
        }
    }
}
