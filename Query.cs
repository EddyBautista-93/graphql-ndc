public class Query
{
    // Resolver
    public string Hello(string name = "World")
        => $"Hello, {name}!";

    public IEnumerable<Book> GetBooks()
    {
        var author = new Author("Jon Skeet");
        // the yield keyword signals to the compiler that the method in which it
        // appears is an iterator block.
        yield return new Book("C# in Depth", author);
        yield return new Book("C# in Depth 2nd Edition", author);
        
    }
}

// Record - Immutable data type.
public record Author(string Name);

public record Book(string Title, Author Author);