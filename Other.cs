using System;

namespace unit2
{
    class OtherStuff
    {
        public static void TicketSeller() {
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
        }

        public static void VowelCounter() {
            string str;
            
            int i, len, vowel;

            Console.Write("Input the string : ");
            str = Console.ReadLine().ToLower();

            vowel = 0;
            len = str.Length;
            Console.WriteLine("Length:" + len);
		
		    for(i=0; i<len; i++) {
                if(str[i] =='a' || str[i]=='e' || str[i]=='i' || str[i]=='o' || str[i]=='u')
                {
                    vowel++;
                }
            }
            Console.Write("\nThe total number of vowels in the input is : {0}\n", vowel);
        }

        public static void WeatherLogic() {
            bool isSunny = false;
            decimal temperature = 12m; // degrees celsius
            int x = 5;

            if (isSunny && (temperature > 4)) 
            {
                Console.WriteLine("I will go outside");
                x = 10;

                if (temperature > 15) {
                    Console.WriteLine("I will wear a t-shirt");
                    x = 100;
                } 
                if (temperature > 30)
                {
                    Console.WriteLine("It is really hot out!");
                    x = 1000;
                } 
                if (temperature > 50) {
                    x = 3000;
                }
            } 
            else 
            {
                Console.WriteLine("I will NOT go outside");
                x = -2;
            }

            Console.WriteLine(x);
        }

        public static void ExContinue() {
            for (int i = 1; i < 50; i++) {               
                // if i is divisible by 3. 
                Console.WriteLine("---i: " + i);
                if (i%3 == 0) {
                    Console.WriteLine("i is divisible by 3");
                    continue;
                    //Console.WriteLine("Hello!");
                }
                Console.WriteLine("end of iteration");
            }

        }

        public static void TicketSeller2() {
            Console.WriteLine("What is the age of the buyer? ");

            int age = Convert.ToInt32(Console.ReadLine());


            if(age>=0 && age<=5)
            {
                Console.WriteLine(" We dont charge for children below 5");
            }
            else if(age>=6 && age <=14)
            {
                Console.WriteLine(" The price is: $8.99 ");
            }
            else if(age>=15 && age<=65)
            {
                Console.WriteLine(" The price is: $12.99 ");
            }
            else if(age>65 && age <=150)
            {
                Console.WriteLine(" The price is: $7.99 ");
            }
            else
            {
                Console.WriteLine(" Please enter a valid value");
            }
        }

        public static void Writing() {
             int a = 10;
            string b = "hello";
            float c = 7.88f;
            bool d = true;

            Console.WriteLine("Here are my variables: a: " + a + ", b: " + b + ", c: " + c + ", d: " + d);

            Console.WriteLine("Here are my variables: a: {0}, b: {1}, c: {2}, d: {3}", a, b, c, d);

            Console.WriteLine($"Here are my variables: a: {a}, b: {b}, c: {c}, d: {d}");
            
        }

        public static void Max3() {
            Console.WriteLine("What is your firs number? ");
            string firstNumber = Console.ReadLine();
            int firstNumberInt = Convert.ToInt32(firstNumber);

            Console.WriteLine("What is your second number? ");
            string secondNumber = Console.ReadLine();
            int secondNumberInt = Convert.ToInt32(secondNumber);

            Console.WriteLine("What is your third number? ");
            string thirdNumber = Console.ReadLine();
            int thirdNumberInt = Convert.ToInt32(thirdNumber);

            
            if (firstNumberInt >= secondNumberInt && firstNumberInt >= thirdNumberInt)
            {
                Console.WriteLine($"First number is the largest.");
            }
            else if (secondNumberInt >= firstNumberInt && secondNumberInt >= thirdNumberInt)
            {
                Console.WriteLine("Second number is the largest.");
            }
            else if (thirdNumberInt >= firstNumberInt && thirdNumberInt >= secondNumberInt)
            {
                Console.WriteLine("Third number is the largest.");
            }
            else
            {
                Console.WriteLine("All three number are equal.");
            }


            /*
                max = 0;
                nums = [1, 2, 5, 6, 0, 99, 34, 198, 45];

                for (i = 0; i < nums.Length; i++) {
                    if (max < nums[i]) {
                        max = nums[i];
                    }
                }
                print(max);

            */
        }

        public static void FizzBuzz()
        {

for (int i = 1; i<= 100; i++) {
                Console.WriteLine(i);
                if (i % 15 == 0) 
                {
                    Console.WriteLine("Fizzbuzz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }


            }

        }
    }
}

