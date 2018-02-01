
//Repeatedly prompt the user for numbers. Add all of the numbers together. When the user types in “done”, print the average of all of the numbers by dividing the total by the number of numbers entered.

//treehouse:~/workspace$ mcs Program.cs && mono Program.exe
//Enter a number or type "done" to see the average: 5.5
//Enter a number or type "done" to see the average: bogus
//That is not valid input.
//Enter a number or type "done" to see the average: 4.2
//Enter a number or type "done" to see the average: 99
//Enter a number or type "done" to see the average: done
//Average: 36.2333333333333
//treehouse:~/workspace 




using System;

namespace Treehouse.Averager
{
  class Averager
  {
    static void Main()
    {
      // initialise
      var runningTotal = 0.0;
      var counter = 0;
      var average = 0.0;
      
      while(true)
      {
        counter++;
        
        Console.Write("Enter a number or type \"done\" to see the average: ");
        var entry = Console.ReadLine();
        
        // check if the user wants to quit
        if(entry.ToLower() == "done")
        {
          break;
        }
        
        try
        {
          var number = double.Parse(entry);
          
          // Check how many minutes the user has entered and give positive feedback
          
          // if a negative number is used, try again
          if(number <= 0)
          {
            Console.WriteLine("That is not valid input.");
            continue;
          }
          else
          {
            continue;
          }
          
          // add the minutes entered to the running total
          runningTotal += number;
          
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
      // calculate average
      average = runningTotal / counter;
      
      Console.WriteLine("Average: " + average);
    }
  }
}
