using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izbornik_i_sortiranje
{
    internal class Program
    {
       static List<string> Dodaj(List<string>  lista)
        {
            Console.WriteLine( "Koji grad zelite dodati?");
            lista.Add(Console.ReadLine());

            return lista;
        }
         static void Citaj(List<string> lista)
        {
            foreach ( string item in lista)
            {
                Console.WriteLine(item);
            }
        }
        static List<string> Sortiraj(List<string> lista)
        {
            int izbor;
            Console.WriteLine("Zelite li soritirati 1. Uzlazno ili 2. silazno");
            izbor=int.Parse(Console.ReadLine());
            switch (izbor)
            {
                case 1:
                    lista.Sort();
                    break;
                case 2:
                    lista.Sort();
                    lista.Reverse();
                    break;
                    

                default:
                    Console.WriteLine("Pogršan unos ");
                    break;
            }
            return lista;
        }
        static void Main(string[] args)
        {
            List<string> lista = new List<string>();
            int izbor = 0;
            while (true)
            {
               
                Console.WriteLine("1. Unos");
                Console.WriteLine("2.Sortiranje");
                Console.WriteLine("3.Ispis");
                Console.WriteLine("4. Izlaz");
                izbor = int.Parse(Console.ReadLine());
                switch (izbor)
                {
                    case 1:
                        lista=Dodaj(lista);
                        break;
                    case 2:
                        lista=Sortiraj(lista);
                        break;
                    case 3:
                        Citaj(lista);
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Nepostojeci izbor");
                        break;
                }

            }
        }
    }
}
