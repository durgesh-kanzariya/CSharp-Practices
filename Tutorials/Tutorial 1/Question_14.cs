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
            string str = Console.ReadLine();
            string outputStr = "";
            foreach(char c in str)
            {
                outputStr += arr[int.Parse(c.ToString())] + " ";
            }
            Console.WriteLine($"OUTPUT: {outputStr}");
        }
    }
}
