using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23SOEIT11008_DURGESH_KANZARIYA.Tutorials.Tutorial_1
{
    internal class Question_14
    {
        static void Main(string[] args)
        {
            string[] arr = {"Zero","One","Two","Three","Four","Five","Six","Seven","Eight","Nine"};
            Console.Write("INPUT: ");
            int number = int.Parse(Console.ReadLine());
            string outputStr = "";
            while (number > 0)
            {
                int reminder = number % 10;
                outputStr = $"{arr[reminder]} " + outputStr;
                number = number / 10;
            }
            Console.WriteLine($"OUTPUT: {outputStr}");
        }
    }
}
