using System;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {

            string userChoice;
            do
            {

                // Ask the user to input a measurement type
                Console.WriteLine("Let's measure the length of your computer monitor. Do you want to measure in inches, feet, fidget spinners, or memes?");
                string userUnit = Console.ReadLine().ToLower();
                Console.WriteLine();

                // Ask the user for an amount and convert result to a double
                Console.WriteLine("How many " + userUnit + " is your computer monitor?");
                double monitorLength = double.Parse(Console.ReadLine());
                Console.WriteLine();

                /*Convert unit measurements
                1 inch 3.5 fidget spinners
                1 foot 5 memes */
                double fidgetSpinner = monitorLength * 3.5;
                double inches = monitorLength / 3.5;
                double meme = monitorLength * 5;
                double feet = monitorLength / 5;

                // Dealing with the user's two options:

                if (userUnit == "inches")
                {
                    Console.WriteLine("Your monitor is " + fidgetSpinner + " fidget spinners long!\n");
                }
                else if (userUnit == "feet")
                {
                    Console.WriteLine("Your monitor is " + meme + " memes long!\n");
                }

                else if (userUnit == "fidget spinners")
                {
                    Console.WriteLine("Your monitor is " + inches + " inches long!\n");
                }

                else if (userUnit == "memes")
                {
                    Console.WriteLine("Your monitor is " + feet + " feet long!\n");
                }

                    // Loop time...
                    Console.WriteLine("Do you want to go again? Yes or No answer, please");
                userChoice = Console.ReadLine().ToLower();
                Console.WriteLine();
            }
            while (userChoice == "yes");


        }
    }
}
