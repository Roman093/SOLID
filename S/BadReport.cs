using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.S
{
    class Report
    {
        static void Main(string[] args)
        {
        }
        public string Text { get; set; }
        public void GoToFirstPage()
        {
            Console.WriteLine("Переход к первой странице");
            Console.ReadKey();
        }

        public void GoToLastPage()
        {
            Console.WriteLine("Переход к последней странице");
        }

        public void GoToPage(int pageNumber)
        {
            Console.WriteLine("Переход к странице {0}", pageNumber);
        }

        public void Print()
        {
            Console.WriteLine("Печать отчета");
            Console.WriteLine(Text);
        }
    }
}
