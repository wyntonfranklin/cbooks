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
    public partial class AddPage : Form
    {
        public Books FormBook;
        public Form1 CurrentForm;

        public AddPage()
        {
            InitializeComponent();
        }

        public AddPage(Form1 MainForm)
        {
            InitializeComponent();
            FormBook = MainForm.getCurrentBook();
            CurrentForm = MainForm;

        }

        private void label1_Click(object sender, EventArgs e)
        {
    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pages nPage = new Pages();
            nPage.Title = pageTitle.Text;
            nPage.Content = pageContent.Text;
            FormBook.addPage(nPage);
            CurrentForm.updatePagesList();
            this.Close();
        }
    }
}
