using System;

internal class EntryPoint
{
    static void Main()
    {
        int[] numbers = { 5, 5, 6, 7, 3, 4, 5, 6 };

        Console.WriteLine(numbers[3]);
        Console.WriteLine(numbers[7]);

        int[] number = new int[5];

        number[0] = 1;
        number[1] = 2;
        number[2] = 3;
        number[3] = 4;
        number[4] = 5;

        Console.WriteLine(number[2]);

        numbers[2] = 50;

        Console.WriteLine(numbers[2]);

        string[] fruitArray = { "apple", "orange", "pear", "kiwi", "watermelon" };
       
        Console.WriteLine(fruitArray[2]);

        string[] fruits = new string[5];

        fruits[0] = "apple";
        fruits[1] = "orange";
        fruits[2] = "pear";
        fruits[3] = "kiwi";
        fruits[4] = "watermelon";

        Console.WriteLine(fruits[3]);
        Console.WriteLine(fruits[3][0]);
    }
}