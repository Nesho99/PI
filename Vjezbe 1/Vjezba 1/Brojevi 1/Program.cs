using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brojevi_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite broj jedinica");
            string jedinica=Console.ReadLine();
            Console.WriteLine("Unesite broj desetica");
            string desetica=Console.ReadLine();
            int parse= (int.Parse(desetica)*10)+ int.Parse(jedinica);
            double rez = parse * 2.1;
            Console.WriteLine($"Rezultat je {rez}");
            Console.ReadLine();
           
        }
    }
}
