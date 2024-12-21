public class Book
{
    public enum GenreEnum
    { 
        Fantasy,
        Detective,
        Romance,
        Mystery,
        Adventure,
        ScienceFiction,
        Horror
    }
    public string AuthorFullName { get; private set; }
    public string Title { get; private set; }
    public int PublishYear { get; private set; }
    public int ISBN { get; private set; }
    public GenreEnum Genre { get; private set; }
    public Book(string authorfullName, string title, int publishYear, int isbn, GenreEnum genre)
    {
        AuthorFullName = authorfullName;
        Title = title;
        PublishYear = publishYear;
        ISBN = isbn;
        Genre = genre;
    }
}