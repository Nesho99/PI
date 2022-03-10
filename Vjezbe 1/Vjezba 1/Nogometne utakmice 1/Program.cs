using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nogometne_utakmice_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] utakmice = new string[7]  {
               "HRV 2:0 NIG",
               "HRV 3:0 ARG",
               "HRV 2:1 ISL",
               "HRV 1:1 DAN",
                "HRV 2:2 RUS",
                "HRV 2:1 ENG",
                "HRV 2:4 FRA" };
            int pobjede=0;
            int izjednacenja = 0;
            int porazi=0;
          
            foreach (var item in utakmice)
            {
               
                    string[] split = item.Split(':');
                    string[] r1 = split[0].Split(' ');
                    string[] r2 = split[1].Split(' ');
                    r1 = r1.ToArray();
                    r2 = r2.ToArray();
                    int rez1=int.Parse(r1[1]);
                    int rez2 = int.Parse(r2[0]);
                if (rez1 > rez2) { pobjede++; }
                else if (rez1 < rez2) { porazi++; }
                else { izjednacenja++;}
              








            }
            Console.WriteLine($"{pobjede} Pobjeda");
            Console.WriteLine($"{porazi} Poraza");
            Console.WriteLine($"{izjednacenja} Izjdnacenja");
            Console.ReadLine();
        
        }
    }
}
