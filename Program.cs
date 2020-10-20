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
            Dictionary<string, int> membre = new Dictionary<string, int>();
            membre.Add("hubert laurent", 20);
            membre.Add("patrick paul", 24);
            membre.Add("john john", 40);
            membre.Add("aaaaa aaaaaa", 20);
            membre.Add("a p", 20);
            membre.Add("p o", 43);
            Console.WriteLine(membre["hubert laurent"]);
            membre.Remove("john john");
            membre.Remove("p o");
            foreach (KeyValuePair<string, int> entry in membre)
            {
                Console.WriteLine(entry.Key + " a " + entry.Value + " ans ");
            }


            Console.ReadLine();
        }
    }
}
