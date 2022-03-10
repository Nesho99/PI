using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime sad=DateTime.Now;
            int godina = sad.Year;
            int mijesec = sad.Month;
            Console.WriteLine("Unesite godinu:");
            int unosGod=int.Parse(Console.ReadLine());
            Console.WriteLine("Unesite mjesec");
            int unosMj=int.Parse(Console.ReadLine());
            if (godina >= unosGod)
            {
                godina = godina - unosGod - 1;
                if (unosMj <= mijesec)
                mijesec = mijesec - unosMj;

            }
            else
            {
                godina = godina - unosGod - 1;
                if (unosMj <= mijesec)
                {
                    mijesec = mijesec - unosMj;

                }
                else { Console.WriteLine("Neispravan unos"); }


                

            }
            int dani = godina * 12 * 30;
            dani += mijesec * 30;
            int mijeseci = godina * 12 + mijesec;
            Console.WriteLine($"{mijeseci} mjeseci");
            Console.WriteLine($"{dani} dana");
            Console.ReadLine();
        }
    }
}
