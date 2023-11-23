namespace oop7;

internal class Book : BookProduct
{
    string ISBN { get; }
    public string CoverType { get; set; }

    public Book(string ISBN)
    {
        this.ISBN = ISBN;
        CoverType = DEFAULT_VALUE;
    }

    public Book(string ISBN, string coverType)
    {
        this.ISBN = ISBN;
        CoverType = coverType;
    }

    public string InfoISBN()
    {
        return ISBN;
    }

    public override string ToString()
    {
        return $"Title - {Title}\n" +
            $"ISBN - {ISBN}\n" +
            $"Cover type - {CoverType}\n";
    }
}