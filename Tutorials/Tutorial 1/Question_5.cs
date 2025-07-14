using System;   // Gives us access to built-in functionality like Console.ReadLine(), WriteLine(), etc.
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23SOEIT11008_DURGESH_KANZARIYA.Tutorials.Tutorial_1  // Defines a namespace
{
    internal class Question_5   // Defines a class named Question_4 
    {
        static void Main(string[] args) // Main method: entry point of the program
        {
            int n, fact = 1;    // Declare an integer 'n' for user input, and 'fact' to store factorial, starting with 1
            Console.WriteLine("Enter Number : ");   // Ask the user to enter a number
            string str = Console.ReadLine();    // Read the input from the user as a string
            n = Convert.ToInt32(str);   // Convert the string input to an integer and store it in 'n'
            for (int i = 1; i <= n; i++)    // Loop from 1 to n
            {
                fact = fact * i;    // Multiply 'fact' with current 'i' to compute factorial step by step
            }
            Console.WriteLine("Factorial : {0}", fact);    // Print the result using string formatting
            Console.Read();    // Wait for user to press any key before closing the console
        }
    }
}
