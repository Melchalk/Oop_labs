namespace oop7;

internal class Library
{
    List<BookProduct> _bookProducts = new();
    List<Book> _books = new();
    List<Magazine> _magazines = new();

    public void Add<T>(T product) where T : BookProduct
    {
        if (product is Book book)
        {
            _books.Add(book);
        }
        else if (product is Magazine magazine)
        {
            _magazines.Add(magazine);
        }
        else
        {
            _bookProducts.Add(product);
        }
    }

    public string Count()
    {
        return $"Book products - {_bookProducts.Count()}\n" +
            $"Books - {_books.Count()}\n" +
            $"Magazines - {_magazines.Count()}\n";
    }
}