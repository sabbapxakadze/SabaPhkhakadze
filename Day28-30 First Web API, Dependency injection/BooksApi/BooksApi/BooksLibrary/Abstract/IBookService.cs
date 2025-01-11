using BooksLibrary.Model;

namespace BooksLibrary.Abstract
{
    public  interface IBookService
    {
        public IEnumerable<Book> GetBooks();
        public Book GetBook(int id);
    }
}
