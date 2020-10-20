using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] age = { 13, 12, 70, 14, 20, 50 };
            string[] prenom = { "antoine", "gregory", "sami", "thomas", "anthony", "baptiste" };
            int l = age.Length;
            for (int i = 0; i < l; i++)
            {
                Console.WriteLine(prenom[i] + " : " + age[i]);
            }
            Console.ReadLine();
        }
    }
}
