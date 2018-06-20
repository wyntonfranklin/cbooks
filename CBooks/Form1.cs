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
        private Books currentBook;
        private Pages currentPage;
        private FolderBrowserDialog folderBrowserDialog1;

        public Form1()
        {
            InitializeComponent();
            Books bk = new Books("hello");
            Pages pg = new Pages("test");
            bk.addPage(pg);
            BookAdapter.AddBook(bk);
            updateList();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form2 fm = new Form2(this);
            fm.ShowDialog();
        }

        private void booksList_SelectedIndexChanged(object sender, EventArgs e)
        {
           // Books bk = (Books)booksList.SelectedItem;
          //  Console.WriteLine(bk.title);
        }

        public void updateList()
        {
            booksList.DataSource = null;
            booksList.Items.Clear();
            booksList.DataSource = BookAdapter.GetAllBooks();
  
        }

        public void updatePagesList()
        {
            pagesList.DataSource = null;
            pagesList.Items.Clear();
            if(currentBook != null)
            {
                pagesList.DataSource = currentBook.getAllPages();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(currentBook != null)
            {
                AddPage pgForm = new AddPage(this);
                pgForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("No Books selected.");
            }
        }

        private void pagesList_DoubleClick(object sender, EventArgs e)
        {
            Pages pg = (Pages)pagesList.SelectedItem;
            currentPage = pg;
            pageTitleBox.Text = pg.Title;
            pageContentBox.Text = pg.Content;
        }

        private void booksList_DoubleClick(object sender, EventArgs e)
        {
            clearPages();
            setBook();
            updatePagesList();
        }

        private void setBook()
        {
            Books bk = (Books)booksList.SelectedItem;
            currentBook = bk;

        }

        private void clearPages()
        {
            currentPage = null;
            pageTitleBox.Text = "";
            pageContentBox.Text = "";

        }


        public Pages getCurrentPage()
        {
            return currentPage;
        }

        public Books getCurrentBook()
        {
            return currentBook;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (currentPage != null)
            {
                currentPage.Title = pageTitleBox.Text;
                currentPage.Content = pageContentBox.Text;
            }
            else
            {
                MessageBox.Show("No Page Selected");
            }
        }

        public void ChooseFolder()
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                //textBox1.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChooseFolder();
        }
    }

}
