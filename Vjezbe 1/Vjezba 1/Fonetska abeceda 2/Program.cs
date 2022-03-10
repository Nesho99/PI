using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fonetska_abeceda_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("unesite riječ napisan fonetskom abecedom");
            string input = Console.ReadLine();
            string[] allowed  = { "Alfa", "Bravo", "Charlie", "Delta", "Echo", "Foxtrot", "Golf", "Hotel", "India", "Juliett", "Kilo", "Lima", "Mike","November","Oscar","Papa","Quebec","Romeo","Sierra","Tango","Uniform","Victor","Whiskey","Xray","Yankee","Zulu"};
            string[] inputArr = input.Split(' ');
            bool error = false;
            string output = "";

            foreach (string  i in inputArr)
            {
                if (allowed.Contains(i))
                {
                 output+=i.First();
                   

                }
                else
                {
                    Console.WriteLine("Nedozvolejni unos");
                    error = true;
                    break;
                   
                   
                }

            }
            if (!error)
            Console.WriteLine($"Napisali ste: {output}");
            Console.ReadLine();
        }
    }
}
