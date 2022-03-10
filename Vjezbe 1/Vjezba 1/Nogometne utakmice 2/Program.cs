using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nogometne_utakmice_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] utakmice =new string[6]  {
                "ARG 1:1 ISL",
                "HRV 2:0 NIG",
                "ARG 0:3 HRV",
                "NIG 2:0 ISL",
                "NIG 1:2 ARG",
                "ISL 1:2 HRV" };
            Console.WriteLine("Unesite reprezentaciju");
            string unos=Console.ReadLine();
            foreach (var item in utakmice)
            {
                if (item.Contains(unos))
                {
                    string[] split = item.Split(':');
                    string[] r1 =split[0].Split(' ');
                    string[] r2 = split[1].Split(' ');
                    r1=r1.ToArray();
                    r2=r2.ToArray();
                    if (r1[0].Contains(unos))
                    {
                        Console.WriteLine($"{r1[0]} {r1[1]}:{r2[0]} {r2[1]}");
                    }
                    else
                    {
                        Console.WriteLine($"{r2[1]} {r2[0]}:{r1[1]} {r1[0]}");
                    }
                   

                }
                

            }
            Console.ReadLine();


        }
    }
}
