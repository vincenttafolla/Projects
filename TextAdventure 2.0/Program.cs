﻿using System;

namespace TextAdventure_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Welcome to the White House! I am President Trump ( ^ ◡ ^)");
                Console.WriteLine("You must be the new security gaurd, would you like a tour");

                string response = Console.ReadLine();


                if (response == "Yes")
                {
                    Console.WriteLine("Would you like to see my HUGE kitchen rarely ever us? (~_^)");
                    response = Console.ReadLine();

                    if (response == "Yes")
                    {
                        // show kitchen
                    }

                    Console.WriteLine("Would you like to see the dining room where all my postmates get delivered?(^_^)");
                    response = Console.ReadLine();

                    if (response == "Yes")
                    {
                        // show dining room
                    }
                    Console.WriteLine("Now would you like to see my briliant plan on how I am gonna make Mexico pay for my HUGE wall?");
                    response = Console.ReadLine();

                    if (response == "Yes")
                    {
                        // show briliant plan
                    }
                    Console.WriteLine("Nevermind what I just said, I was kidding about that I am an honest person I could never take advantage of a corrupt country.(:");
                    response = Console.ReadLine();

                    if (response == "Yes")
                    {
                        // moving on...
                    }

                    Console.WriteLine("Now for my masterpiece *pushes Melania Trump to the side* my TRAIN COLLECTION!!!!");
                    Console.WriteLine("*runs over to the trains and says* BING BING BONG BING BING");
                    Console.WriteLine("Ok, bye now (-_^), *type Bye*");
                    response = Console.ReadLine();

                    if (response == "Bye")
                    {
                        // goodbye
                    }
                    Console.WriteLine("Oh, forgot to mention YOU'RE FIRED!!!");
                }
                else if (response == "No")
                {
                    Console.WriteLine("Are you sure about that?");
                    response = Console.ReadLine();

                    if (response == "Yes")
                    {
                        // making sure 
                    }
                    Console.WriteLine("YOU'RE FIRED!!");
                    Console.WriteLine("Hello World!");
                }
            }
        }
    }
}
