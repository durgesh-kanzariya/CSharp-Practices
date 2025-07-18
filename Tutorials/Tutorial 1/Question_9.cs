using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23SOEIT11008_DURGESH_KANZARIYA.Tutorials.Tutorial_1
{
    internal class Question_9
    {
        static void Main(string[] args)
        {
            Console.Write("INPUT:");
            string str = Console.ReadLine();
            Console.WriteLine(str);
            String outString = "";
            foreach(char character in str)
            {
                if (char.IsUpper(character))
                {
                    outString += char.ToLower(character);
                }
                else
                {
                    outString += char.ToUpper(character);
                }
            }
            Console.Write($"{outString}");
        }
    }
}
