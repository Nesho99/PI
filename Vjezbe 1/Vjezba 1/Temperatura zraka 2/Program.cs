using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatura_zraka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string meteoStanica = "13,2;C|286,85;K|-|14,8;C|15,1;C|287,95;K|14,2;C|13,7;C";
            string[] temprature=meteoStanica.Split('|');
            foreach (var item in temprature)
            {
               ;
                if (item == "-")
                {
                    Console.WriteLine("Nije uspjelo");
                    continue;
                }
                string[] split = item.Split(';');
                split[0] = split[0].Replace(',', '.');
                double temp = double.Parse(split[0]);

                if (split[1] == "K")
                {
                   
                    temp = temp -273.15 ;
                    Console.WriteLine($"Temperatura je {temp} C");

                }
                else
                {
                    Console.WriteLine($"Temperatura je {temp} C");

                }

            }
            Console.ReadLine();
        }
    }
}
