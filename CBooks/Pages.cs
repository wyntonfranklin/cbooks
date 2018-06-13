using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBooks
{
    public class Pages
    {
        public String Title { get; set; }
        public String Content { get; set; }
        private int WordCount { get; set; }
        private int CurrentLine { get; set; }


        public Pages()
        {

        }

        public Pages(String pageName)
        {
            Title = pageName;
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
