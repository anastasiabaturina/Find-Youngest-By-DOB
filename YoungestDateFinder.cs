namespace FindYoungestByDOB;

public class YoungestDateFinder
{
    public static void FindYoungestDates(DateTime[] dates)
    {
        Array.Sort(dates);
        Console.WriteLine($"{dates[^2]}, {dates[^1]}");
    }
}
