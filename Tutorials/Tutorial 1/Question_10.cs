using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23SOEIT11008_DURGESH_KANZARIYA.Tutorials.Tutorial_1
{
    internal class Question_10
    {
        static void Main(string[] args)
        {
            Console.Write("INPUT: ");
            string str = Console.ReadLine();
            string outString = "";
            for (int i = 0; i < 5; i++) 
            {
                outString = outString + str[i];
            }
            outString = outString + "XXXXX";
            Console.WriteLine($"OUTPUT: {outString}");
        }
    }
}
