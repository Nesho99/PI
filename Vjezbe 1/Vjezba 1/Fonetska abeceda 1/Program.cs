using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fonetska_abeceda_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cipher = { "Alfa", "Bravo", "Charlie", "Delta", "Echo", "Foxtrot", "Golf", "Hotel", "India", "Juliett", "Kilo", "Lima", "Mike", "November", "Oscar", "Papa", "Quebec", "Romeo", "Sierra", "Tango", "Uniform", "Victor", "Whiskey", "Xray", "Yankee", "Zulu" };
            Console.WriteLine("Unesite rijec");
            string output = "";
            string input= Console.ReadLine();
            foreach (char i in input)
            {
                foreach (string s in cipher)
                {
                    if(s.First() == i)
                    {
                        string temp = s + " ";
                        output+= temp;

                    }
                }
            }
           Console.WriteLine($"Vaša riječ je {output}");
            Console.ReadLine();
        }
    }
}
