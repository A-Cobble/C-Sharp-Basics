using System;

internal class EntryPoint
{
    static void Main()
    {
        string exeFile = @"Word.exe""";
        string pathToExe = @"""C:\Program Files\Microsoft Word\";

        Console.WriteLine(pathToExe + exeFile);
        //use backslashes to display '\' and '"' included in a string
        Console.WriteLine("C:\\Program Files\\\"Microsoft Programs\"\\'VisualStudio'");

        //use the @ symbol to escape display '\' and '"' included in a string
        Console.WriteLine(@"C:\Program Files\""Microsoft Programs""\'VisualStudio'");

        //use double '{' to display curly brackets in an interpolated string 
        //to interpolate a string use '$' followed by a double quotation mark and a curly bracket
        Console.WriteLine($"{{{pathToExe}{exeFile}}}");
    }
}