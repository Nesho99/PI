using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konverzija
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite cijelobrjoni iznos");
            string unos=Console.ReadLine();
            string[] unosArr = unos.Split(' ');
            int pow = unosArr.Length - 1;
            double rez=0;
            int trenutni=0;
            Console.WriteLine("Unesite tecaj");
            float tecaj=float.Parse(Console.ReadLine());
            foreach (string s in unosArr)
            {
                switch (s)
                {
                    case "jedan":
                        trenutni = 1;
                            break;
                    case "dva":
                        trenutni=2;
                        break;
                    case "tri":
                        trenutni = 3;
                        break;
                    case "četiri":
                        trenutni = 4;
                        break;
                    case "pet":
                        trenutni = 5;
                        break;
                    case "šest":
                        trenutni = 6;
                        break;
                    case "sedam":
                        trenutni = 7;
                        break;
                    case "osam":
                        trenutni = 8;
                        break;
                    case "devet":
                        trenutni = 9;
                        break;
                    default:
                        break;
                }
                rez+= trenutni* Math.Pow(10, pow);
                pow -= 1;
            }
            double rez2 = tecaj*rez;
            Console.WriteLine($"{rez} eura je {rez2} kuna");
            Console.ReadKey();
        }
    }
}
