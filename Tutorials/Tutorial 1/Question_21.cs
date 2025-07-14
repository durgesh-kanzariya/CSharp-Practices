using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23SOEIT11008_DURGESH_KANZARIYA.Tutorials.Tutorial_1
{
    internal class Question_21
    {
        static void Main(string[] args)
        {
            Console.Write("Input the number of terms: ");
            int term = int.Parse(Console.ReadLine());
            Console.Write("Input number: ");
            string number = Console.ReadLine();
            int sum = 0;
            string termStr;
            string expOutput ="";
            for(int i = 0; i < term; i++)
            {
                termStr = "";
                for(int j = 0; j < i+1; j++)
                {
                    termStr += number;
                }
                expOutput += termStr+" + ";
                sum += int.Parse(termStr);
            }
            expOutput = expOutput.Remove((expOutput.Length)-3,2);
            Console.WriteLine($"Expected Output: {expOutput}");
            Console.WriteLine($"The Sum is: {sum}");
        }
    }
}
