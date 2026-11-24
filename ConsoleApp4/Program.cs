using System;
using System.Globalization;

public class Program
{
    public static void Main()
    {
        string normalDate = "2025-01-15";
        string weirdDate = "15/Jan/2025";
        string badDate = "не дата";

        Console.WriteLine("--- Parse ---");
        try
        {
            DateTime d1 = DateTime.Parse(normalDate, CultureInfo.InvariantCulture);
            Console.WriteLine($"Parse сработал: {d1:yyyy-MM-dd}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Parse не смог распознать формат");
        }

        Console.WriteLine("\n--- ParseExact ---");
        try
        {
            DateTime d2 = DateTime.ParseExact(normalDate, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            Console.WriteLine($"ParseExact сработал: {d2:yyyy-MM-dd}");
        }
        catch (FormatException)
        {
            Console.WriteLine("ParseExact: формат не совпал");
        }

        Console.WriteLine("\n--- TryParse ---");
        bool ok1 = DateTime.TryParse(badDate, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime r1);
        Console.WriteLine($"TryParse с плохими данными: {ok1}, результат: {r1}");

        bool ok2 = DateTime.TryParse(normalDate, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime r2);
        Console.WriteLine($"TryParse с хорошими данными: {ok2}, результат: {r2:yyyy-MM-dd}");

        Console.WriteLine("\n--- TryParseExact ---");
        bool ok3 = DateTime.TryParseExact(weirdDate, "dd/MMM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime r3);
        Console.WriteLine($"TryParseExact с совпадающим форматом: {ok3}, результат: {r3:yyyy-MM-dd}");

        bool ok4 = DateTime.TryParseExact(weirdDate, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime r4);
        Console.WriteLine($"TryParseExact с несовпадающим форматом: {ok4}, результат: {r4}");
    }
}