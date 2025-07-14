using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23SOEIT11008_DURGESH_KANZARIYA.Tutorials.Tutorial_1
{
    internal class Question_13
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter count: ");
            int count  = int.Parse(Console.ReadLine());
            int[] arr = new int[count];
            arr[0] = 0;
            arr[1] = 1;
            for (int i = 2; i < count; i++)
            {
                arr[i] = arr[i-1]+arr[i-2];
            }
            for (int i = 0; i < count; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }
    }
}
