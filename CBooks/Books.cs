using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBooks
{
    public class Books
    {
        public int Id { get; set; }
        public String Title { get; set; }
        private int Pages { get; set; }
        private int Sections { get; set; }
        public string description;
        public List<Pages> pg = new List<Pages>();


        private string GetDescription()
        {
            return description;
        }

        private void SetDescription(string value)
        {
            description = value;
        }

        public Books()
        {

        }


        public Books(String bookName)
        {
            Title = bookName;
        }

        public Books(int book_id, String bookName)
        {
            Id = book_id;
            Title = bookName;
        }

        public override string ToString()
        {
            return Title;
        }

        public void addPage(Pages page)
        {
            pg.Add(page);
        }

        public List<Pages> getAllPages()
        {
            return pg;
        }

    }
}
