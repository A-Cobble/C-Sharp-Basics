using System;

internal class EntryPoint
{
    static void Main()
    {
        //use the special character single quotation marks then comma and number of times you want it repeated
        string separator = new string('-', 50);

        string fruit = "strawberry";
        string juice = "juice";
        int dollarSigns = 10000;

        //the information inside the curly bracket is a modifier. The first value is the index of the first place holder
        //the second number specifies where the last character will end
        Console.WriteLine("{0,15}", fruit);
        Console.WriteLine("{0,15}", juice);
        Console.WriteLine($"{fruit,15}");
        Console.WriteLine($"{juice,15}");
        //to display a number as currency use the format specifier ':C'
        Console.WriteLine($"{dollarSigns,15:C}");

        Console.WriteLine(separator);

        float proteinOnMonday = 80.88557f;
        float proteinOnTuesday = 94.56465f;
        float proteinOnWednesday = 78.67893f;
        float proteinOnThursday = 88.66654f;
        float proteinOnFriday = 88.6466f;
        float proteinOnSaturday = 76.777f;
        float proteinOnSunday = 91.85759f;
        float totalProteinForWeek = proteinOnMonday + proteinOnTuesday + proteinOnWednesday + proteinOnThursday + proteinOnFriday + proteinOnSaturday + proteinOnSunday;

        string lineSeparator = "|";
        string week = "1";
        string total = "Total: ";
        string weeklyProteinIntake = "Protein Intake Week: ";
        int lengthOfTitle = weeklyProteinIntake.Length + week.Length;
        string equalSigns = new string('=', lengthOfTitle);

        Console.WriteLine($"{lineSeparator}{weeklyProteinIntake}{week}{lineSeparator}");
        Console.WriteLine($"{lineSeparator}{equalSigns}{lineSeparator}");
        Console.WriteLine($"{lineSeparator}{proteinOnMonday,22:F}{lineSeparator}");
        Console.WriteLine($"{lineSeparator}{proteinOnTuesday,22:F}{lineSeparator}");
        Console.WriteLine($"{lineSeparator}{proteinOnWednesday,22:F}{lineSeparator}");
        Console.WriteLine($"{lineSeparator}{proteinOnThursday,22:F}{lineSeparator}");
        Console.WriteLine($"{lineSeparator}{proteinOnFriday,22:F}{lineSeparator}");
        Console.WriteLine($"{lineSeparator}{proteinOnSaturday,22:F}{lineSeparator}");
        Console.WriteLine($"{lineSeparator}{proteinOnSunday,22:F}{lineSeparator}");
        Console.WriteLine($"{lineSeparator}{equalSigns}{lineSeparator}");
        Console.WriteLine($"{lineSeparator}{total}{totalProteinForWeek,15:F}{lineSeparator}");
    }
}