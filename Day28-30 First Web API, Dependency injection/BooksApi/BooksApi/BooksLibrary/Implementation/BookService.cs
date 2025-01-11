using BooksLibrary.Abstract;
using BooksLibrary.Model;

namespace BooksLibrary.Implementation
{
    public class BookService : IBookService
    {
        private List<Book> _books = new List<Book>
            {
                new Book(1, "The Midnight Library", "Matt Haig", 2020),
                new Book(2, "Sapiens: A Brief History of Humankind", "Yuval Noah Harari", 2014),
                new Book(3, "Atomic Habits", "James Clear", 2018),
                new Book(4, "Dune", "Frank Herbert", 1965)
            };
        public Book GetBook(int id)
        {
            return _books.SingleOrDefault(x => x.Id == id);
        }

        public IEnumerable<Book> GetBooks()
        {
            return _books;
        }
    }
}
