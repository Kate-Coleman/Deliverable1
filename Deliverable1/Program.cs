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
                Console.WriteLine("Let's measure the length of your computer monitor. Do you want to measure in inches or feet?");
                string userUnit = Console.ReadLine();

                // Ask the user for an amount and convert result to a double
                Console.WriteLine("How many " + userUnit + " is your computer monitor?");
                double monitorLength = double.Parse(Console.ReadLine());

                /*Convert unit measurements
                1 inch 3.5 fidget spinners
                1 foot 5 memes */
                double fidgetSpinner = monitorLength * 3.5;
                double meme = monitorLength * 5;

                // Dealing with the user's two options:

                if (userUnit == "inches")
                {
                    Console.WriteLine("Your monitor is " + fidgetSpinner + " fidget spinners long!");
                }
                else if (userUnit == "feet")
                {
                    Console.WriteLine("Your monitor is " + meme + " memes long!");
                }

                // Loop time...
                Console.WriteLine("Do you want to go again? Yes or No answer, please");
                userChoice = Console.ReadLine();

            }
            while (userChoice == "Yes");


        }
    }
}
