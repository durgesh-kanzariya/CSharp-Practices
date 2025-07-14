using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23SOEIT11008_DURGESH_KANZARIYA.Tutorials.Tutorial_1
{
    internal class Question_22
    {
        static void Main(string[] args)
        {
            int n = 9;
            for (int i = 0; i < n; i++) 
            {
                int z;
                if(i > (n / 2))
                {
                    z = n - i - 1;
                }
                else
                {
                    z = i;
                }
                for (int k = n/2; k > z; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < (2*z)+1; j++) 
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
