using System;

internal class EntryPoint
    {
        static void Main()
        {
            int someInteger = 265;
        // Integers -> 2^32
        int intMax = int.MaxValue;
        int intMin = int.MinValue;

        System.Console.WriteLine(intMax);
        System.Console.WriteLine(intMin);

        uint someUInteger = 5;
        uint maxUInt = uint.MaxValue;
        uint minUInt = uint.MinValue;

        System.Console.WriteLine(minUInt);
        System.Console.WriteLine(maxUInt);

        System.Console.WriteLine(Math.Pow(2, 32));

        byte someByteNumber = 255;

        byte minByte = byte.MinValue;
        byte maxByte = byte.MaxValue;

        Console.WriteLine(minByte);
        Console.WriteLine(maxByte);

        sbyte minsByte = sbyte.MinValue;
        sbyte maxsByte = sbyte.MaxValue;

        Console.WriteLine(minsByte);
        Console.WriteLine(maxsByte);

        long minLong = long.MinValue;
        long maxLong = long.MaxValue;

        Console.WriteLine(minLong);
        Console.WriteLine(maxLong);


        ulong maxULong = ulong.MaxValue;

        Console.WriteLine(maxULong);
    }
}