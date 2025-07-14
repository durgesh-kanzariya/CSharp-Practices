using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23SOEIT11008_DURGESH_KANZARIYA.Tutorials.Tutorial_1
{
    internal class Question_15
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            string numberStr = Console.ReadLine();
            int sum = 0;
            int intrateNum;
            foreach (char i in numberStr)
            {
                intrateNum = int.Parse(i.ToString());
                for (int j = 0; j < (numberStr.Length) - 1; j++) 
                {
                    intrateNum = intrateNum * int.Parse(i.ToString());
                }
                sum += intrateNum;
            }
            if (sum == int.Parse(numberStr)) 
            {
                Console.WriteLine($"Number {numberStr} is armstrong number.");
            }
            else
            {
                Console.WriteLine($"Number {numberStr} is not an armstrong number.");
            }
        }
    }
}
