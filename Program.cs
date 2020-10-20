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
            double a = 12 + 5 * 12.5 - 1253.68;
            Console.WriteLine(a);

            double b = 0;
            double[] val = new double[5] { 1.0, 5.5, 9.9, 2.8, 9.6 };
            for (int i = 0; i < val.Length; i++)
            {
                b += val[i];
            }

            double moy = b / val.Length;
            Console.WriteLine(moy);

            Console.WriteLine("rayon de cercle");
            double rayon = double.Parse(Console.ReadLine());
            double per = 2 * Math.PI * rayon;
            double s = Math.PI * rayon * rayon;
            Console.WriteLine("perimetre " + per);
            Console.WriteLine("surface " + s);

            string chaine = "zenat";


            Console.ReadLine();
        }
    }
}
