using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice4
{
    internal class BookComparerCustom : IComparer<Book>
    {
        public int Compare(Book? x, Book? y)
        {
            if (x.PublishYear * x.ISBN > y.PublishYear * y.ISBN)
                return 1;
            else if (x.PublishYear * x.ISBN < y.PublishYear * y.ISBN)
                return -1;
            else return 0;
        }
    }
}
