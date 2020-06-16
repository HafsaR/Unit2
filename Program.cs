using System;

namespace unit2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a Base 10 integer:");
            string userInput = Console.ReadLine();
            int base10Int = Convert.ToInt32(userInput);
            string result = ConvertBase10ToBinary(base10Int);
            Console.WriteLine("Result is: " + result);
        }


        static string ConvertBase10ToBinary(int myNumber) {
            string result = "";

            if (myNumber == 0) {
                return "0";
            }

            while (myNumber > 0) {
                int remainder = myNumber % 2;
                myNumber = myNumber / 2;
                result += remainder;
            }

            // Reverses a string
            string finalResult = ReverseAString(result);
            return finalResult;
        }

        static string ReverseAString(string stringToReverse) {
            string finalResult = "";
            for (int i = stringToReverse.Length - 1; i >= 0; i--) {
                finalResult += stringToReverse[i];
            }

            return finalResult;
        }
    }
}

