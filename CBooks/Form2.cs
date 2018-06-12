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
    public partial class Form2 : Form
    {
        public Form1 currentForm;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Form1 fm)
        {
            InitializeComponent();
            currentForm = fm;
        }

        private void saveBook_Click(object sender, EventArgs e)
        {
            Books bk = new Books();
            bk.Title = bookName.Text.ToString();
            bk.description = bookDescription.Text.ToString();
            BookAdapter.AddBook(bk);
            currentForm.updateList();
            this.Hide();

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
