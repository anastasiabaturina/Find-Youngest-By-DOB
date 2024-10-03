namespace FindYoungestByDOB;

public class Program()
{
    public static void Main(string[] args)
    {
        var dates = new[] 
        {
        DateTime.Parse("2022-10-31T08:30:45.123Z"),
        DateTime.Parse("2019-10-31T08:20:45.123Z"),
        DateTime.Parse("2021-09-19T08:40:45.123Z"),
        DateTime.Parse("2023-01-15T08:30:45.123Z")
        };

        YoungestDateFinder.FindYoungestDates(dates);
    }
}