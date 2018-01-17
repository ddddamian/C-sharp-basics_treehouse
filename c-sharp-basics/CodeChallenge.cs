using System;

namespace Treehouse.CodeChallenges
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the number of times to print \"Yay!\": ");
            var entry = Console.ReadLine();
            
            var number = int.Parse(entry);
            
            while(number > 0)
            {
                Console.WriteLine("Yay!");
                number -= 1;
            }
        }
    }
}
