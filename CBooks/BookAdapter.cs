using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBooks
{
    class BookAdapter
    {
        public static List<Books> bks = new List<Books>();

        public static void AddBook(Books bk)
        {
            bks.Add(bk);
        }

        public static List<Books> GetAllBooks()
        {
            return bks;
        }
    }
}
