using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starost_osobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int trenutniDan = 7;
            int trenutniMijesc = 3;
            int trenutnaGodina = 2022;
            Console.WriteLine("Unesite datum rođenja");
            string input=Console.ReadLine();
            string[] inputArr=input.Split(' ');
            int korisnikDan=int.Parse(inputArr[0]);
            int korisnikMijesec = 0;
            string stringMijesec=inputArr[1];
            switch (stringMijesec)
            {
                case "siječanj":
                    korisnikMijesec=1;
                    break;
                case "veljača":
                    korisnikMijesec=2;
                    break;
                case "ožujak":
                    korisnikMijesec = 3;
                    break;
                case "travanj":
                    korisnikMijesec = 4;
                    break;
                case "svibanj":
                    korisnikMijesec = 5;
                    break;
                case "lipanj":
                    korisnikMijesec = 6;
                    break;
                case "srpanj":
                    korisnikMijesec = 7;
                    break;
                case "kolovoz":
                    korisnikMijesec = 8;
                    break;
                case "rujan":
                    korisnikMijesec = 9;
                    break;
                case "listopad":
                    korisnikMijesec = 10;
                    break;
                case "studeni":
                    korisnikMijesec = 11;
                    break;
                case "prosinac":
                    korisnikMijesec = 12;
                    break;
                default:
                    break;
            }
            int korisnikGodina = trenutnaGodina - int.Parse(inputArr[2]);
            if (korisnikMijesec < trenutniMijesc)
            {
                Console.WriteLine($"Korisnik je napunio {korisnikGodina} godina");
            } else if(korisnikMijesec>trenutniMijesc){
                Console.WriteLine($"Korisnik  će napuniti {korisnikGodina} godina");

            }
            else
            {
                if(korisnikDan< trenutniDan)
                {
                    Console.WriteLine($"Korisnik je napunio {korisnikGodina} godina");
                }
                else
                {
                    Console.WriteLine($"Korisnik  će napuniti {korisnikGodina} godina");

                }
            }
            Console.ReadLine();
            
        }
    }
}
