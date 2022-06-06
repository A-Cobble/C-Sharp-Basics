using System;

internal class EntryPoint
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.WriteLine("A turtle made it to the water.");
        Console.WriteLine("I've collected many things over the years");
        Console.ResetColor();
        Console.Write("The ");
        Console.BackgroundColor = ConsoleColor.Red;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("cycle of life");
        Console.ResetColor();
        Console.Write(" can be cruel.\n");



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

        ConsoleColor separatorsColor = ConsoleColor.Red;
        ConsoleColor dataBackground = ConsoleColor.Green;
        ConsoleColor totalBackground = ConsoleColor.DarkBlue;
        ConsoleColor headlineBackground = ConsoleColor.DarkYellow;

        Console.ForegroundColor = ConsoleColor.White;

        Console.BackgroundColor = separatorsColor;
        Console.Write($"{lineSeparator}{equalSigns}{lineSeparator}\n");
        Console.Write($"{lineSeparator}");

        Console.BackgroundColor = headlineBackground;
        Console.Write($"{weeklyProteinIntake}{week}");

        Console.BackgroundColor = separatorsColor;
        Console.Write($"{lineSeparator}\n");
        Console.Write($"{lineSeparator}{equalSigns}{lineSeparator}\n");
        Console.Write($"{lineSeparator}");

        Console.BackgroundColor = dataBackground;
        Console.Write($"{proteinOnMonday,22:F}");

        Console.BackgroundColor = separatorsColor;
        Console.Write($"{lineSeparator}\n");
        Console.Write($"{lineSeparator}");

        Console.BackgroundColor = dataBackground;
        Console.Write($"{proteinOnTuesday,22:F}");

        Console.BackgroundColor = separatorsColor;
        Console.Write($"{lineSeparator}\n");
        Console.Write($"{lineSeparator}");

        Console.BackgroundColor = dataBackground;
        Console.Write($"{proteinOnWednesday,22:F}");

        Console.BackgroundColor = separatorsColor;
        Console.Write($"{lineSeparator}\n");
        Console.Write($"{lineSeparator}");

        Console.BackgroundColor = dataBackground;
        Console.Write($"{proteinOnThursday,22:F}");

        Console.BackgroundColor = separatorsColor;
        Console.Write($"{lineSeparator}\n");
        Console.Write($"{lineSeparator}");

        Console.BackgroundColor = dataBackground;
        Console.Write($"{proteinOnFriday,22:F}");

        Console.BackgroundColor = separatorsColor;
        Console.Write($"{lineSeparator}\n");
        Console.Write($"{lineSeparator}");

        Console.BackgroundColor = dataBackground;
        Console.Write($"{proteinOnSaturday,22:F}");

        Console.BackgroundColor = separatorsColor;
        Console.Write($"{lineSeparator}\n");
        Console.Write($"{lineSeparator}");

        Console.BackgroundColor = dataBackground;
        Console.Write($"{proteinOnSunday,22:F}");

        Console.BackgroundColor = separatorsColor;
        Console.Write($"{lineSeparator}\n");
        Console.Write($"{lineSeparator}{equalSigns}{lineSeparator}\n");
        Console.Write($"{lineSeparator}");

        Console.BackgroundColor = totalBackground;
        Console.Write($"{total}{totalProteinForWeek,15:F}");

        Console.BackgroundColor = separatorsColor;
        Console.Write($"{lineSeparator}\n");
        Console.Write($"{lineSeparator}{equalSigns}{lineSeparator}\n");

        Console.ResetColor();
    }
}