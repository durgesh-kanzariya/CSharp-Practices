using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23SOEIT11008_DURGESH_KANZARIYA.Tutorials.Tutorial_1
{
    internal class Question_3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            if (number == 0) {
                Console.WriteLine($"Number {number} is zero.");
            }
            else if (number % 2 == 0)
            {
                Console.WriteLine($"Number {number} is even.");
            }
            else
            {
                Console.WriteLine($"Number {number} is odd.");
            }
        }
    }
}
