using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Popis_ii_posudba_knjiga
{
    internal class Program
    {
        struct Liste
        {
             public List<string> d;
            public  List<string> p;

        }
        static void Popis(List<string> p, List<string> d)
        {
            foreach (var item in d)
            {

                Console.WriteLine($"{item} Status:(dostupna)");
            }
            foreach (var item in p)
            {

                Console.WriteLine($"{item} Status:(posudena)");

            }
        }
        static Liste Posudi(List<string> p, List<string> d, string input)
        {
            input = input.Substring(8);
            if (d.Contains(input))
            {
                d.Remove(input);
                p.Add(input);
            }
            Liste l;
            l= new Liste();
            l.d = d;
            l.p = p;
            return l;


        }
        static void Main(string[] args)
        {
           
            string input = "";
            List<String> posuđene= new List<String>();
            List<String> dostupne= new List<String>();
            dostupne.Add("Prstenova druzina");
            dostupne.Add("Dvije kule");
            dostupne.Add("Jadnici");
            dostupne.Add("Rat i mir");
            posuđene.Add("Zolcin i kazna");
            posuđene.Add("Povratak kralja");
            while (true)
            {
                Console.WriteLine("Unesite naredbu");
                input= Console.ReadLine();
                if (input.Contains("#popis"))
                {
                    Popis(posuđene, dostupne);

                }else if (input.Contains("#posudi"))
                {
                    Liste l=Posudi(posuđene,dostupne,input);
                    posuđene = l.p;
                    dostupne = l.d;


                }else if (input.Contains("#exit"))
                {
                  Environment.Exit(0);
                }
                else { Console.WriteLine("Pogrešan unos"); }


            }

        }
    }
}
