using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice4
{
    internal class BookComparerTitle : IComparer<Book>
    {
        public int Compare(Book? x, Book? y)
        {
            if (x.Title.CompareTo(y.Title) > 0)
                return 1;
            else if (x.Title.CompareTo(y.Title) < 0)
                return -1;
            else
                return 0;
        }
    }
}
