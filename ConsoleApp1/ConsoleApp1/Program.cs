using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Declare a boolean variable named "keepGoing"
            // and assign it a value of "true". Use this variable to 
            // know when to exit the while loop.
            bool keepGoing = true;

            // TODO Define a while loop.
            // Keep looping as long as the variable "keepGoing" has a value of "true".
            while (keepGoing)
            {
                // TODO Prompt the user with the text "Enter a number:" 
                Console.Write("Pick a number: ");
                string entry = Console.ReadLine();
                // and assign their value to an "entry" string variable.

                // TODO If the user entered the text "quit"...
                if (entry == "quit")
                {
                    // TODO Else the user didn't enter the text "quit"...
                    keepGoing = false;
                }
                else
                {
                    // TODO Parse the user's entry to an integer
                    int number = int.Parse(entry);
                    // TODO Square the user's provided number 
                    // (i.e. multiply the number by itself).
                    int result = number * number;
                    // TODO Output the result.
                    Console.WriteLine("The square of " + number + " is " + result);
                    // Example: "The square of 2 is 4." or 
                    // "2 multiplied by itself is equal to 4."
                }
            }
            // TODO Output the text "Goodbye!" after exiting the loop.
            Console.WriteLine("GoodBye!!!");

        }
    }
}
