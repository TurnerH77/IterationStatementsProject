using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a List called "numbers" - DONE
            var numbers = new List<int>();

            //Create a variable of type int and initialize the variable with a value of 0
            int num = 0;


            do
            {
                num++;
                numbers.Add(num);
            } while (num < 100);



            while (num < 200)
            {
                num++;
                numbers.Add(num);
            }

            Console.WriteLine("Increase:");

            // Create a foreach loop
            // Write your variable to the console
            foreach(int nums in numbers)
            {
                Console.WriteLine(nums);
            }

            Console.WriteLine("");
            Console.WriteLine("Decrease:");

            // Create a for loop
            // in your initializer set the value of i to 199
            // in your conditional, as long as i is less than or equal to the length of "numbers"
            // and as long as i is greater than or equal to 0
            // Decrement i by 1
            for(int i = 199; i <= numbers.Count && i >=0; i--)
            {
                // Write to the console "numbers" at index i
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
