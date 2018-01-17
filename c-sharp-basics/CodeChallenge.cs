using System;

namespace Treehouse.CodeChallenges
{
    class Program
    {
        static void Main()
        {
            // initialise
            var number = 0;
            
            Console.Write("Enter the number of times to print \"Yay!\": ");
            var entry = Console.ReadLine();
            
            // try/catch exception handling for non-numeric inputs
            try
            {
                // convert string to an integer
                number = int.Parse(entry);
                
                // input validation to check for a positive number
                if(number < 0)
                {
                    Console.Write("You must enter a positive number.");
                }
            }
            catch(FormatException)
            {
                Console.WriteLine("You must enter a whole number.");
            }
            
            // write "Yay!" as many times as the user has input
            while(number > 0)
            {
                Console.WriteLine("Yay!");
                number -= 1;
            }
        }
    }
}
