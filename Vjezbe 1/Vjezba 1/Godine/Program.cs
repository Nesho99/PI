using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Godine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite svoju godinu rođenja");
            int rođ= int.Parse(Console.ReadLine());
            int starost = 2022 - rođ;
            int prijestupne = 0;
            for (int i = rođ; i < 2022; i++)
            {
                if (i % 4!=0)
                {
                    continue;

                }else if (i % 100 != 0)
                { prijestupne++;}
                else if(i % 400 != 0) { continue; }
                else { prijestupne++;}
                
                    
            }
            Console.WriteLine($"Imate {starost}  ili {starost-1} godina i preživjeli ste {prijestupne} prijestupnih godina");
            Console.ReadLine();

        }
    }
}
