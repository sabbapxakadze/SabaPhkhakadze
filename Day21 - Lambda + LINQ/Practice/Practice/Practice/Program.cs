using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

public class Program
{
    // Consolidated Logging
    public delegate void LogMessage(string message);
    public static void logConsole(string message)
    {
        Console.WriteLine(message);
    }
    public static void logFile(string message)
    {
        using (FileStream fs = new FileStream("log.txt", FileMode.OpenOrCreate, FileAccess.Write))
        {
            var bytes = System.Text.Encoding.UTF8.GetBytes(message);

            fs.Write(bytes, 0, bytes.Length);
        }
    }
    // ----------------------------------------- 

    // Sequential Calculations
    public delegate decimal MathOperation(decimal v1, decimal v2);
    public static decimal Add(decimal v1, decimal v2)
    {
        return v1 + v2;
    }
    public static decimal Sub(decimal v1, decimal v2)
    {
        return v1 - v2;
    }
    public static decimal Mul(decimal v1, decimal v2)
    {
        return v1 * v2;
    }
    public static decimal Div(decimal v1, decimal v2)
    {
        if (v2 == 0) throw new DivideByZeroException();
        return v1 / v2;
    }



    static void Main(string[] args)
    {
        Console.WriteLine("// Consolidated Logging");

        LogMessage multiLogger = logConsole;
        multiLogger += logFile;

        multiLogger.Invoke("Real, Deep!");
        Console.WriteLine("// -----------------------------------------\n");



        Console.WriteLine("// Sequential Calculations");
        MathOperation mathOps1 = Add;
        mathOps1 += Mul;
        MathOperation mathOps2 = Sub;
        mathOps2 += Mul;
        mathOps2 += Div;
        Console.WriteLine(mathOps1.Invoke(1.5m, 2.3m));
        Console.WriteLine(mathOps2.Invoke(10m, 40m));
        Console.WriteLine("// -----------------------------------------\n");


        Console.WriteLine("// Chained Validation");
        Book b = new Book("Gaseirneba Kiushi", "Saba", 123, "", DateTime.Now,
            Book.GenreEnum.Adventure, 10, null, 100
            );

        Book.Validator validator;
        validator = Book.ValidateAuthor;
        validator += Book.ValidateGenre;
        validator = validator + Book.ValidatePublisher + Book.ValidatePublicationDate + Book.ValidateISBN + Book.ValidateIsAvailable + Book.ValidateNumberOfPages;
        validator += Book.ValidateTitle;

        foreach (var x in validator.GetInvocationList())
        {
            var method = (Book.Validator)x;
            bool res = method(b);

            if (res == false)
                Console.WriteLine($"{method.Method.Name} failed validation");
        }
        Console.WriteLine("// ----------------------------------------------\n");


        Console.WriteLine("// Custom Data Pipelines");
        List<Book> books = new List<Book>
        {
            new Book("Gaseirneba Kiushi", "Saba", 123, "Iveria", DateTime.Now,
            Book.GenreEnum.Adventure, 99, false, 100
            ),
            new Book("Gaseirneba Kiushi2", "Lika", 1323, "Iberia", DateTime.Now,
            Book.GenreEnum.Adventure, 99, false, 100
            ),
            new Book("Gaseirneba Sadme", "Vaja", 1232222222, "Saqartvelo", DateTime.Now,
            Book.GenreEnum.Horror, 1320, true, 100
            ),
            new Book("Gaseirneba Shors", "Mari", 12312312213, "Ravici", DateTime.Now,
            Book.GenreEnum.Fiction, 110, true, 100
            ),
            new Book("Gaseirneba Axlos", "James", 1234334243223, "Rame", DateTime.Now,
            Book.GenreEnum.Detective, 130, null, 100
            ),

        };

        var resultBooks = books.Where(b => b.NumberOfPages < 100) 
                                .Where(b => b.IsAvailable == false)  
                                .Where(b => b.PublicationDate > new DateTime(2021, 12, 12));  
        
        DataPipeline<Book, BookDto> dataPipeline = new DataPipeline<Book, BookDto>();

        dataPipeline.SetTransform(BookDto.BookToBookDto);

        List<BookDto> transformedBooks = dataPipeline.Process(resultBooks);
        
        foreach (var dto in transformedBooks)
        {
            Console.WriteLine("New BookDTO with {0},{1},{2},{3},{4}", dto.Title, dto.Author, dto.Genre, dto.Price, dto.IsAvailable);
        }
        Console.WriteLine();
        Console.WriteLine("// ----------------------------------------------\n");
    }
}