using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            var array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */
            var evens = new List<int>();
            var odds = new List<int>();

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */
            foreach (int number in array)
            {
                if (number % 2 == 0)
                {
                    evens.Add(number);
                }
                else 
                {
                    odds.Add(number);
                }
            }

            /* Now using foreach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
            foreach (int even in evens) 
            {
                if (even == 8)
                {
                    Console.WriteLine($"{even}...\nWho do we appreciate?");
                }

                else if (even == 10)
                {
                    Console.WriteLine($"{even}!");
                }
                else 
                {
                    Console.WriteLine($"{even}...");
                }
               
            }
            Console.WriteLine();

            foreach (int odd in odds) 
            {
                if (odd == 9)
                {
                    Console.WriteLine($"All multiples of {odd}!");
                }
                else 
                {
                    Console.WriteLine($"{odd}...");
                }
            }
        }
    }
}
