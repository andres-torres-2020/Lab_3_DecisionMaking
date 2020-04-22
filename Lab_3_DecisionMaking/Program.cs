/*
 * A.TORRES
 * 
 * Lab 3 - Decision Making
 * 
 * The application prompts to the user to enter an integer between 1 and 100.
 * The application displays the associated result based on the integer range entered.
 *
 * If the integer is odd, print the number entered and “Odd.”
 * If the integer entered is even and in the inclusive range of 2 to 25, print “Even and less than 25.”
 * If the integer entered is even and in the inclusive range of 26 to 60, print “Even.”
 * If the integer entered is even and greater than 60, print the number entered and “Even”.
 * If the integer entered is odd and greater than 60, print the number entered and “Odd.”
 */
using System;

namespace Lab_3_DecisionMaking
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            string continueResponse = "y";
            while (continueResponse == "y")
            {
                Console.Write($"{name}, enter an integer between 1 and 100: ");
                string input = Console.ReadLine().Trim();
                int number = int.Parse(input);

                Console.Write($"{name}, ");
                if (number < 1 || number > 100)
                {
                    // number out of acceptable range
                    Console.WriteLine("only enter a positive integer between 1 and 100.");
                }
                else if (number % 2 == 0)
                {
                    // even
                    bool isBelow60 = number <= 60;
                    if (!isBelow60)
                    {
                        Console.Write($"{number} ");
                    }

                    Console.Write("Even");

                    if (number <= 25)
                    {
                        Console.Write(" and less than 25");
                    }

                    if (isBelow60)
                    {
                        Console.Write(".");
                    }
                    Console.WriteLine("");
                }
                else
                {
                    // odd
                    Console.WriteLine($"{number} Odd.");
                }

                // prompt for continuation or conclusion
                do
                {
                    Console.Write($"{name}, continue? (y/n) ");
                    continueResponse = Console.ReadLine().Trim().ToLower();
                } while (continueResponse != "y" && continueResponse != "n");
                Console.WriteLine("");
            }
            Console.WriteLine($"Bye, {name} !");
        }
    }
}
