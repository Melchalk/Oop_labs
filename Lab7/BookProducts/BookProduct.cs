using System;

namespace oop7;

internal class BookProduct
{
    protected const string DEFAULT_VALUE = "Не задано";
    public string Title { get; set; }
    public int YearOfRelease { get; set; }
    public string Publisher { get; set; }

    public BookProduct()
    {
        Title = DEFAULT_VALUE;
        Publisher = DEFAULT_VALUE;
        YearOfRelease = -1;
    }

    public BookProduct(string title, string publisher, int yearOfRelease)
    {
        Title = title;
        Publisher = publisher;
        YearOfRelease = yearOfRelease;
    }

    public override string ToString()
    {
        return $"Title - {Title}\n" +
            $"Year of Release - {YearOfRelease}\n" +
            $"Publisher - {Publisher}\n";
    }
}