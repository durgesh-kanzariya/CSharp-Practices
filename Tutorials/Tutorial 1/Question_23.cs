using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23SOEIT11008_DURGESH_KANZARIYA.Tutorials.Tutorial_1
{
    internal class Question_23
    {
        static void Main(string[] args)
        {
            int k;
            int l;
            int n = 9;
            for (int i = 0; i < n; i++)
            {
                if (i > (n / 2))
                {
                    k = n - i;
                }
                else
                {
                    k = i + 1;
                }
                if (i < 4)
                {
                    l = n - i - 5;
                }
                else
                {
                    l = i - 4;
                }
                for (int m = 0; m < l; m++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < k; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
