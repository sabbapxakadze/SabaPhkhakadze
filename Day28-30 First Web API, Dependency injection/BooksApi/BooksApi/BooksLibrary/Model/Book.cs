namespace BooksLibrary.Model
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int YearPublished { get; set; }
        public Book(int id, string title, string author, int yearPublished)
        {
            Id = id;
            Title = title;
            Author = author;
            YearPublished = yearPublished;
        }
    }
}