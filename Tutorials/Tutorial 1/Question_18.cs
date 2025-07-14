using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23SOEIT11008_DURGESH_KANZARIYA.Tutorials.Tutorial_1
{
    internal class Question_18
    {
        static void Main(string[] args)
        {
            int count = 0;
            int n = 4;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    count++;
                    Console.Write($"{count} ");
                }
                Console.WriteLine();
            }
        }
    }
}
