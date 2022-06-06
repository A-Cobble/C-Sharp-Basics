using System;

internal class EntryPoint
{
    static void Main()
    {
        Console.Write("How old are you?");

        //Console.Read returns the decimal ASCII code of the first pressed character
        //When typecasting it to a Character, it only returns the first pressed character
        char age = (char)Console.Read();
        Console.WriteLine($"My age is {age}");
    }
}