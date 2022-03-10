using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novcana_naknada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ime="", smijena;
            string input;
            int brojSati;
            double total=0;
            Console.WriteLine("Unesite ime");
            input=Console.ReadLine();
            string[] satiRada = new string[]  {
                "Ivan Ivic;8NS",
                "Ivan Ivic;6DS",
                "Ivan Ivic;4DS",
                "Ivan Ivic;4P",
                "Pero Peric;3NS",
                "Pero Peric;5DS",
                "Pero Peric;7DS",
                "Pero Peric;4DS",
                "Pero Peric;3P",
              };
            foreach (string  s in satiRada)
            {
                string[] split = s.Split(';');
                ime=split[0];
                smijena=split[1].Substring(1);
                brojSati = int.Parse(split[1].Substring(0, 1));
                if (input == ime)
                {
                    switch (smijena)
                    {
                        case "DS":
                            total += brojSati * 150;
                            break;
                        case "NS":
                            total += brojSati * 150 * 1.5;
                            break;
                        case "P":
                            total += brojSati * 150 * 2;
                            break;
                        default:
                            break;
                    }
                }

            }
            Console.WriteLine($"Zaposleniku {ime} treba ispaltiti {Math.Round(total,2)} KN");
            Console.ReadLine();
        }
    }
}
