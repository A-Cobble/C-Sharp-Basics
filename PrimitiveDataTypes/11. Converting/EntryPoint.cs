using System;

internal class EntryPoint
{
    static void Main()
    {
        int number = 5;
        string word = "5";
        char x = 'x';
        float pi = 3.14f;

        float integer = number;
        
        //the floating and int data types are compatible but there is a loss of information
        int floating = (int)pi;

        Console.WriteLine(integer);
        Console.WriteLine(floating);

        // ctrl + r, r   = allows you to change all variables with the highlighted name at the same time
        // convert will output a 0 if the variable has a value of null
        int convertedString = Convert.ToInt32(word);
        Console.WriteLine(convertedString);

        // parsed will output an error/exception if the variable has a value of null
        int parsedString = int.Parse(word);
        Console.WriteLine(parsedString);
    }
}