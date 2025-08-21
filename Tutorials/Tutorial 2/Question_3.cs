using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23SOEIT11008_DURGESH_KANZARIYA.Tutorials.Tutorial_2
{
    internal class Question_3
    {
        static void Main(string[] args)
        {
            String firstName = "John";
            String lastName = "Doe";
            Console.WriteLine("Name: " + firstName + " " + lastName);
            Console.WriteLine("Please enter a new first name:");
            firstName = Console.ReadLine();
            Console.WriteLine("New name: " + firstName + " " + lastName);
            Console.ReadLine();
        }
    }
}
