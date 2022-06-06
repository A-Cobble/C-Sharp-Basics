using System;

internal class EntryPoint
{
    static void Main()
    {
        string separator = new string('=', 40);
        string fruitJuice = "Strawberry juice";


        Console.WriteLine(fruitJuice.Contains("berry"));
        Console.WriteLine(separator);
        Console.WriteLine(fruitJuice.IndexOf("berry"));
        Console.WriteLine(separator);
        Console.WriteLine(fruitJuice.LastIndexOf("berry"));

        bool containsStraw = fruitJuice.ToLower().Contains("straw");

        Console.WriteLine(fruitJuice.ToUpper());
        Console.WriteLine(separator);
        Console.WriteLine(containsStraw);
    }
}