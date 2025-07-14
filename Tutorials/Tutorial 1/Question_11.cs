using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23SOEIT11008_DURGESH_KANZARIYA.Tutorials.Tutorial_1
{
    internal class Question_11
    {
        static void Main(string[] args)
        {
            Console.Write("NAME: ");
            string name = Console.ReadLine();
            Console.Write("GENDER: ");
            string genderStr = Console.ReadLine();
            char gender = genderStr.ToLower()[0];
            if(gender == 'f')
            {
                Console.WriteLine($"Ms. {name}");
            }else
            {
                Console.WriteLine($"Mr. {name}");
            }
        }
    }
}
