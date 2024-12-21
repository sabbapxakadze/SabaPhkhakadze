public class BookDto
{
    public string Title { get; set; }
    public string Author { get; set; }
    public Book.GenreEnum? Genre { get; set; }
    public bool? IsAvailable { get; set; }
    public int Price { get; set; }
    public BookDto(string title, string author, Book.GenreEnum? genre, bool? isAvailable, int price)
    {
        Title = title;  
        Author = author;
        Genre = genre;
        IsAvailable = isAvailable;
        Price = price;
    }

    public static BookDto BookToBookDto(Book b)
    {
        return new BookDto(b.Title, b.Author, b.Genre, b.IsAvailable, b.Price);
    }
    public delegate BookDto TransformationDelegate(Book b);
}