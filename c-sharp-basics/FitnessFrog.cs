using System;

namespace Treehouse.FitnessFrog
{
  class Program
  {
    static void Main()
    {
      // initialise
      var runningTotal = 0.0;
      
      while(true) {
        // Prompt the user for minutes exercised
        Console.Write("Enter how many minutes you exercised or type \"quit\" to exit: ");
        var entry = Console.ReadLine();
        
        // check if the user wants to quit
        if(entry.ToLower() == "quit")
        {
          break;
        }
        
        // Add minutes exercised to total
        
        // Exception handling to check that an int or double is entered.
        try
        {
          var minutes = double.Parse(entry);
          
          // Check how many minutes the user has entered and give positive feedback
          
          // if a negative number is used, try again
          if(minutes <= 0)
          {
            Console.WriteLine(minutes + " is not an acceptable value.");
            continue;
          }
          else if(minutes <= 10)
          {
            Console.WriteLine("Better than nothing, am I right?");
          }
          else if(minutes <= 30)
          {
            Console.WriteLine("Way to go hot stuff!");
          }
          else if(minutes <= 60)
          {
            Console.WriteLine("You must be a ninja warrior in training!");
          }
          else
          {
            Console.WriteLine("Okay, now you're just showing off!");
          }
          
          // add the minutes entered to the running total
          runningTotal += minutes;
          
          //Display total minutes exercised to the screen
          Console.WriteLine("You've exercised " + runningTotal + " minutes");
          
          // Repeat until the user quits
        }
        // handle the exception is non-numeric text is enetered
        catch(FormatException)
        {
          Console.WriteLine("That is not valid input.");
          continue;
        }
      }
      Console.WriteLine("Goodbye");
    }
  }
}
