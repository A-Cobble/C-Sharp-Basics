using System;

internal class EntryPoint
{
    static void Main()
    {
        Console.Write("How old are you? ");
        string age = Console.ReadLine();
        Console.WriteLine($"My age is {age}");

        string separator = new string('-', 50);
        Console.WriteLine(separator);

        Console.Write("Input the drive letter: ");
        string driveLetter = Console.ReadLine();
        Console.Write("Input the folder path: ");
        string folderPath = Console.ReadLine();
        Console.Write("Input the file name: ");
        string fileName = Console.ReadLine();

        Console.WriteLine($"{driveLetter}:\\{folderPath}\\{fileName}.exe");
    }
}