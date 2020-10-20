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
            var fruits = new List<string> { "pomme", "poire", "orange", "banane", "kiwi" };
            fruits.Remove("banane");
            foreach (var fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
            
            Console.ReadLine();
        }
    }
}
