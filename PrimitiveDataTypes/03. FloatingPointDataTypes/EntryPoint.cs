using System;

internal class EntryPoint
{
    static void Main()
    {
        float someFloatNumber = 63453453576574.234f;

        Console.WriteLine(someFloatNumber.ToString("f"));

        Console.WriteLine(Math.PI * Math.Pow(3,2));

        float pi = 3.14f;
        float radius = 5f;
        
        float areaOfACircle = pi * radius * radius;
        
        Console.WriteLine(areaOfACircle);

        float fMax = float.MaxValue;
        float fMin = float.MinValue;

        Console.WriteLine(fMax.ToString("f"));
        Console.WriteLine(fMin.ToString("f"));

        double dVariable = 321.123d;

        double doubleMax = double.MaxValue;
        double doubleMin = double.MinValue;

        Console.WriteLine(doubleMax.ToString("f"));
        Console.WriteLine(doubleMin.ToString("f"));

        decimal decimalMax = 5435.543543543543543543543m;
        decimal decimalMin = decimal.MinValue;

        Console.WriteLine(decimalMax);
        Console.WriteLine(decimalMin);
    }
}