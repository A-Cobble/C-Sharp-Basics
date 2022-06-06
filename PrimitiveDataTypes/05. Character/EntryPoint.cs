using System;
using System.Text;

internal class EntryPoint
{
    static void Main()
    {
        //the next two lines change the input and output encoding for the console
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;
        
        char theCharacterX = 'x';

        System.Console.WriteLine(theCharacterX);

        //use the Hx code on the ASCII table (www.asciiTable.com)
        //char must use single quotation marks and is called by '\u0000' <- change the 0 to whatever the ascii table has for the symbol
        char thePlusSign = '\u002B';

        System.Console.WriteLine(thePlusSign);

        //the unicode table has more characters than the ascii table
        // the ability to output the unicode is dependent on the font and the encoding settings of the console itself
        char theOwithTwoDots = '\u00F6';

        System.Console.WriteLine(theOwithTwoDots);

        char theYenSign = '\u00A5';

        Console.WriteLine(theYenSign);
    }
}