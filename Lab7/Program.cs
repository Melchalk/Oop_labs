using oop7;

Library library = new();

Console.WriteLine("----Info of book products----\n");

BookProduct newspaper = new()
{
    Title = "VEGETARIAN",
    YearOfRelease = 2017,
};

Console.WriteLine(newspaper);

library.Add(newspaper);

BookProduct booklet = new()
{
    Title = "Animal Adventure",
    Publisher = "Darice"
};

Console.WriteLine(booklet);
library.Add(booklet);

Console.WriteLine("----Info of books----\n");

Book book1 = new("978-5-00131-235-2")
{
    Title = "Anxious people",
    YearOfRelease = 2020,
    CoverType = "Hardcover"
};

Console.WriteLine((BookProduct)book1); //anyway output like book
library.Add(book1);

Book book2 = new("978-5-00139-270-5")
{
    Title = "The brain and its needs: From nutrition to recognition",
    YearOfRelease = 2023,
    Publisher = "Alpina non-fiction"
};

Console.WriteLine(book2);
library.Add(book2);

library.Add(new Book("978-5-389-22012-6")
{
    Title = "My hero academia",
    YearOfRelease = 2022,
    CoverType = "Hardcover",
    Publisher = "ABC"
});

Console.WriteLine("----Info of magazine----\n");

Magazine magazine = new("2038-1377-56628")
{
    Title = "THE VOICEMAG",
    YearOfRelease = 2023,
    Publisher = "Independent Media",
    IssueNumber = 5
};

Console.WriteLine(magazine);
library.Add(magazine);

library.Add(new Magazine("2227-7986-23008")
{
    Title = "Quantum",
    YearOfRelease = 2023,
    Publisher = "ICNMO",
    IssueNumber = 8
});

Console.WriteLine(library.Count());