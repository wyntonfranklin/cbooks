using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBooks
{
    class Pages
    {
        private String title { get; set; }
        private String content { get; set; }
        private int wordCount { get; set; }
        private int currentLine { get; set; }


        public Pages()
        {

        }

        public Pages(String pageName)
        {
            title = pageName;
        }
    }
}
