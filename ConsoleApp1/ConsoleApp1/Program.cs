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
           
                int runningTotal = 0;
                bool keepGoing = true;

                while (keepGoing)
                {
                    //Prompt user for minutes exercised
                    Console.Write("Enter how many minutes you exercised or type \"quit\" to exit: ");

                    string entry = Console.ReadLine();

                    if (entry == "quit")
                    {
                        keepGoing = false;
                    }
                    else
                    {
                        int minutes = int.Parse(entry);

                        if (minutes <= 10)
                        {
                            Console.WriteLine("At least you're trying");
                        }
                        else if (minutes <= 30)
                        {
                            Console.WriteLine("Wow, nice work out");
                        }
                        else if (minutes <= 60)
                        {
                            Console.WriteLine("You're a ninja!");
                        }
                        else
                        {
                            Console.WriteLine("Now you're just showing off!!");
                        }
                        runningTotal = runningTotal + minutes;

                        //Add minutes exercised to a total
                        //Display total minutes excersied to the screen
                        Console.WriteLine("You've exercised " + runningTotal + " minutes.");
                        //Repeat until user quits
                    }
                }
                Console.WriteLine("Goodbye");
            }
        }
}
