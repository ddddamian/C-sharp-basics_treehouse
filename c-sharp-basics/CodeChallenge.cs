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
            
            try
            {
                number = int.Parse(entry);
            }
            catch(FormatException)
            {
                Console.WriteLine("You must enter a whole number.");
            }
            
            
            while(number > 0)
            {
                Console.WriteLine("Yay!");
                number -= 1;
            }
        }
    }
}
