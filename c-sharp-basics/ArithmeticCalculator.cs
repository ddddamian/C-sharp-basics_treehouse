//Arithmetic Calculator

//Create a calculator that does one arithmetic operation at a time and prints the result to the screen.

//    Prompt the user for a number.
//    Prompt the user for an operation (+ - / *).
//    Prompt the user for another number.
//    Perform the operation.
//    Print the result to the screen.
//    Repeat until the user types in “quit” at any of the prompts.

//Extra Credit: Add the power operator using the ^ symbol. You can calculate a number raised to a power using the Math.Pow method. 

using System;

namespace ArithmeticCalculator
{
  class Program
  {
    static void Main()
    {
      var entry = "";
      while(entry != "quit")
      {
        //    Prompt the user for a number.
        Console.Write("Please type a number: ");
        entry = Console.ReadLine();
        var number1 = int.parse(entry);

        //    Prompt the user for an operation (+ - / *).
        Console.Write("Please type an operation (+ - / *): ");
        entry = Console.ReadLine();
        var operation = entry;

        //    Prompt the user for another number.
        Console.Write("Please type another number: ");
        entry = Console.ReadLine();
        var number2 = int.parse(entry);

        //    Perform the operation.
        var result = number1 + operation + number;
        if (operation == '+')
        {
          result = number1 + number2;
        }
        else if (operation == '-')
        {
          result = number1 - number2;
        }
        else if (operation == '/')
        {
          result = number1 / number2;
        }
        
        //    Print the result to the screen.
        Console.WriteLine(result);
      }
    }
  }
}
