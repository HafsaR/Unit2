using System;

namespace unit2
{
    class Program
    {
        static void Main(string[] args)
        {
            // int currentYear = 2020;

            string myName = "Regan"; //String is double quotes

            bool isWearingBlue = false;

            char symbol = 'V'; // Character is single quotes

            // 8 bits
            // byte byte1 = 255; // Unsigned: 0 -> 255
            // sbyte sbyte1 = -100; // Signed: -128 -> 127

            // // 16 bits
            // short short1 = -32767; // Signed: -32768 -> +32767 
            // ushort ushort1 = 65535; // Usigned: 0 -> 65535 (2^16) - 1

            // 32 bits
            //uint x = 3892372; // Unsigned: 0 -> (2^32) - 1
            //int y = -2147483648; // Signed: -2147483648 -> +2147483647 (-2^31 -> (2^31) - 1)

            // 64 bits
            //ulong x = 88888888888888999;
            //long y = -88888888888888999;

            // float myFloat = 1.5f;
            // double myDouble = 1.00004;
            // decimal myDecimal = 1.000000000000000012m;

            //float theFloat = 3.555f;
            //decimal x = theFloat;

            string myString = "hello";
            myString += " world";
            Console.WriteLine(myString);

            //Console.WriteLine(x);
            //Console.WriteLine("y is " + y);


        }
    }
}

