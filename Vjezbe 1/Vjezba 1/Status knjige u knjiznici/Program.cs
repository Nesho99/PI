using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Status_knjige_u_knjiznici
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] knjige =
            {
                "Prstenova druzina; Dostupna",
                "Dvije kule;Dostupna",
                "Povratak kralja;Na posudbi",
                "Rat i mir;Dostupna",
                "Zlocin i kazna;Na posudbi",
                "Jadnici;Dostupna",

            };
            while (true)

            {
                Console.WriteLine("Naredba:");
                string unos = Console.ReadLine();
                if (unos.Contains("#exit")) { Environment.Exit(0); }
                else if (unos.Contains("#status"))
                {
                    bool ima = false;
                    unos=unos.Substring(8);
                    foreach (string item in knjige)
                    {
                        string[] split = item.Split(';');
                        if (unos == split[0])
                        {
                            ima = true;
                            Console.WriteLine($"Knjiga {split[0]} je {split[1].ToLower().Trim()}");
                            break;

                        }

                    }
                    if (!ima)
                    {
                        Console.WriteLine($"Knjiga {unos} ne postoji");

                    }
                }
            }
           
            

        }
    }
}
