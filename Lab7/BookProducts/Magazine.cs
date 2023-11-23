namespace oop7;

internal class Magazine : BookProduct
{
    private string ISSN { get; }
    public int IssueNumber { get; set; }

    public Magazine(string ISSN)
    {
        this.ISSN = ISSN;
        IssueNumber = 0;
    }

    public Magazine(string ISSN, int issueNumber)
    {
        this.ISSN = ISSN;
        IssueNumber = issueNumber;
    }

    public string InfoISSN()
    {
        return ISSN;
    }

    public override string ToString()
    {
        return $"Title - {Title}\n" +
            $"ISSN - {ISSN}\n" +
            $"IssueNumber - {IssueNumber}\n";
    }
}