public class Book
{
    public enum GenreEnum
    {
        Adventure,
        Fiction,
        Horror,
        Detective
    }
    public string Title { get; set; }
    public string Author { get; set; }
    public long ISBN { get; set; }
    public string Publisher { get; set; }
    public DateTime PublicationDate { get; set; }
    public GenreEnum? Genre { get; set; }
    public int? NumberOfPages { get; set; }
    public bool? IsAvailable { get; set; }
    public int Price { get; set; }
    public delegate bool Validator(Book book);
    public Book(string title, string author, long isbn, string publisher,
        DateTime pubDate, GenreEnum genre, int? numOfPages, 
        bool? isAvailable, int price
        )
    {
        Title = title;
        Author = author;
        Publisher = publisher;
        ISBN = isbn;
        Publisher = publisher;
        PublicationDate = pubDate;
        Genre = genre;
        NumberOfPages = numOfPages;
        IsAvailable = isAvailable;
        Price = price;
    }

    public static bool ValidateTitle(Book b)
    {
        if (b.Title == null)
            return false;

        if (b.Title.Length > 255 || b.Title.Length < 1) return false;
        return true;
    }
    public static bool ValidateAuthor(Book b)
    {
        if (b.Author == null)
            return false;

        if (b.Author.Length > 128 || b.Author.Length < 3) return false;
        return true;
    }
    public static bool ValidateISBN(Book b)
    {
        if (b.ISBN.ToString().Length != 13) return false;
        return true;
    }
    public static bool ValidatePublisher(Book b)
    {
        if (b.Publisher == null) return false;
        return b.Publisher.Length > 2 && b.Publisher.Length < 64;
    }
    public static bool ValidatePublicationDate(Book b)
    {
        return b.PublicationDate < DateTime.Now;
    }

    public static bool ValidateGenre(Book b)
    {
        if (b.Genre == null) return false;
        return true;
    }
    public static bool ValidateNumberOfPages(Book b)
    {
        return b.NumberOfPages > 0;
    }
    public static bool ValidateIsAvailable(Book b)
    {
        if (b.IsAvailable == null) return false;
        return b.IsAvailable.Value;
    }
}