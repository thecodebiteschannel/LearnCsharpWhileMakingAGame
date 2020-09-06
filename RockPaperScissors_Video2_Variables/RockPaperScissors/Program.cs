using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            // int for numbers
            // string for text
            string userInput;
            // Show an instructions message to the user
            Console.WriteLine("Please enter an option using the keyboard: R for Rock, P for Paper, or S for Scissors.");
            // Assignation operator (=) or equal sign
            // Value on the right side of the equal sign will be stored in the variable on the left side
            userInput = Console.ReadLine();
            // Show the value stored in the variable to the user
            Console.WriteLine("You have entered: " + userInput);
            // Wait for the user to press any key
            Console.ReadKey();
        }
    }
}
