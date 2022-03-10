using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potencije
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("X=");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Y=");
            int y = int.Parse(Console.ReadLine());
            double rez = x;
            string exp = "";
            if (y < 0)
            {
                for (int i = 0; i < y-1; i++)
                {
                    rez *= (1 / x);
                    exp += 1 / x + "*";
                }

            }
            else
            {
                for (int i = 0; i < y-1; i++)
                {
                    rez *= x;
                    exp += x + "*";

                }




            }
            exp += x;
            exp += "=" + rez;
            Console.WriteLine(exp);
            Console.ReadLine();



        }
    }
}