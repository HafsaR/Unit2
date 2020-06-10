using System;

namespace unit2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the age of the buyer? ");

            string stringAge = Console.ReadLine();
            int age = Convert.ToInt32(stringAge);
            decimal price = 0m;

            if (age <= 5) {
                price = 0m;
            }
            else if (age >= 6 && age <= 14) {
                price = 8.99m;
            } 
            else if (age > 14 && age <= 65) {
                price = 12.99m;
            }
            else {
                price = 7.99m;
            }

            Console.WriteLine("Ticket Price: " + price);


            // for (int i = 1; i < 50; i++) {               
            //     // if i is divisible by 3. 
            //     Console.WriteLine("---i: " + i);
            //     if (i%3 == 0) {
            //         Console.WriteLine("i is divisible by 3");
            //         continue;
            //         Console.WriteLine("Hello!");
            //     }
            //     Console.WriteLine("end of iteration");
            // }



            // int j = 0;
            // while (j < 50) {
            //     Console.WriteLine("hello");
            //     j += 5;
            // }




            //bool isSunny = false;
            //decimal temperature = 12m; // degrees celsius

            // if (isSunny && (temperature > 4)) 
            // {
            //     Console.WriteLine("I will go outside");
            //     x = 10;

            //     if (temperature > 15) {
            //         Console.WriteLine("I will wear a t-shirt");
            //         x = 100;
            //     } 
            //     if (temperature > 30)
            //     {
            //         Console.WriteLine("It is really hot out!");
            //         x = 1000;
            //     } 
            //     if (temperature > 50) {
            //         x = 3000;
            //     }
            // } 
            // else 
            // {
            //     Console.WriteLine("I will NOT go outside");
            //     x = -2;
            // }


/*
        for (int i = 1; 1<= 100; i++;)
        
        if (i % 15 == 0);
            {Console.WriteLine("Fizzbuzz");}
        
        else (i % 5 == 0);
            {Console.WriteLine("Buzz");}

        else (i % 3 == 0);
            {Console.WriteLine("Fizz");}

*/


        }
    }
}

