using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBooks
{
    class Books
    {
        public int Id { get; set; }
        public String title { get; set; }
        private int pages { get; set; }
        private int sections { get; set; }
        private String description { get; set; }

        public Books()
        {

        }

        public Books(String bookName)
        {
            title = bookName;
        }

        public Books(int book_id, String bookName)
        {
            Id = book_id;
            title = bookName;
        }

    }
}
