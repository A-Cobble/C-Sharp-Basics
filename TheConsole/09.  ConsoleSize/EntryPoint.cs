using System;

internal class EntryPoint
{
    static void Main()
    {
        //Window size sets the visual size of the window not the total area of the console
        //Console.WindowHeight = 25;
        //Console.WindowWidth = 25;
        Console.SetWindowSize(25, 15);
        //Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);

        //Buffer controls the actual size of the window (ie the scrolling bars)
        //buffer size must be >= the Window size
        //Console.BufferWidth = 20;
        //Console.BufferHeight = 20;
        Console.SetBufferSize(25, 15);

        //WindowLeft and WindowTop control where you are viewing in the console (ie it will move the scrolling bars)
        //WindowPosition must be < the differance between the bufferSize - WindowSize
        //Console.WindowLeft = 10;
        //Console.WindowTop = 10;
        //Console.SetWindowPosition(10,10);

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
        Console.Write($"{proteinOnMonday,22:N2}");

        Console.BackgroundColor = separatorsColor;
        Console.Write($"{lineSeparator}\n");
        Console.Write($"{lineSeparator}");

        Console.BackgroundColor = dataBackground;
        Console.Write($"{proteinOnTuesday,22:N2}");

        Console.BackgroundColor = separatorsColor;
        Console.Write($"{lineSeparator}\n");
        Console.Write($"{lineSeparator}");

        Console.BackgroundColor = dataBackground;
        Console.Write($"{proteinOnWednesday,22:N2}");

        Console.BackgroundColor = separatorsColor;
        Console.Write($"{lineSeparator}\n");
        Console.Write($"{lineSeparator}");

        Console.BackgroundColor = dataBackground;
        Console.Write($"{proteinOnThursday,22:N2}");

        Console.BackgroundColor = separatorsColor;
        Console.Write($"{lineSeparator}\n");
        Console.Write($"{lineSeparator}");

        Console.BackgroundColor = dataBackground;
        Console.Write($"{proteinOnFriday,22:N2}");

        Console.BackgroundColor = separatorsColor;
        Console.Write($"{lineSeparator}\n");
        Console.Write($"{lineSeparator}");

        Console.BackgroundColor = dataBackground;
        Console.Write($"{proteinOnSaturday,22:N2}");

        Console.BackgroundColor = separatorsColor;
        Console.Write($"{lineSeparator}\n");
        Console.Write($"{lineSeparator}");

        Console.BackgroundColor = dataBackground;
        Console.Write($"{proteinOnSunday,22:N2}");

        Console.BackgroundColor = separatorsColor;
        Console.Write($"{lineSeparator}\n");
        Console.Write($"{lineSeparator}{equalSigns}{lineSeparator}\n");
        Console.Write($"{lineSeparator}");

        Console.BackgroundColor = totalBackground;
        Console.Write($"{total}{totalProteinForWeek,15:N2}");

        Console.BackgroundColor = separatorsColor;
        Console.Write($"{lineSeparator}\n");
        Console.Write($"{lineSeparator}{equalSigns}{lineSeparator}\n");

        Console.ResetColor();

    }
}