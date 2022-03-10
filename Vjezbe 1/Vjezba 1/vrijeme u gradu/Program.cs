using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vrijeme_u_gradu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime utc0 = DateTime.Now.AddHours(-1);
            string[] gradovi = { "Santiago",
                                "Salvador",
                                "London",
                                "Zagreb",
                                "Damask",
                                "Istanbul"
            };
            string[] odmak =
            {
                "UTC-4","UTC-3,","UTC+0","UTC+1","UTC+2","UTC+3"
            };
            Console.WriteLine("Unesite grad");
            string input=Console.ReadLine();
            int index=0;
            foreach (string grad in gradovi)
            {
                if (input.Contains(grad))
                    
                {
                    DateTime dtVrijeme;
                    int vrijeme=0;
                    string predznak = odmak[index].Substring(3,1);
                    vrijeme = int.Parse(odmak[index].Substring(4,1));
                    dtVrijeme = new DateTime();
                    if (predznak == "-")
                    {
                        dtVrijeme=utc0.AddHours(-vrijeme);
                         Console.WriteLine($"U {grad} je {dtVrijeme.ToString("HH:mm")}");
                    break;
                    }
                    else { dtVrijeme=utc0.AddHours(vrijeme);}

                    Console.WriteLine($"U {grad} je {dtVrijeme.ToString("HH:mm")}");
                    break;
                }   
            }
            Console.ReadLine();
        }
    }
}
