using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Svijetsko_vrijeme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] odmak =
            {
                "Santiago; -4",
                         "Salvador; -3",
                          "London; +0",
                          "Zagreb; +1",
                          "Damask; +2",
                          "Istanbul; +3"


        };
                        
            DateTime utcNow = DateTime.Now.AddHours(-1);
            foreach (string s in odmak)
            {
                string[] split=s.Split(';');
                string city=split[0];
                char sign=split[1].Trim().First();
                int odmakInt=int.Parse(split[1].Trim().Last().ToString());
                string vrijeme = "";


                if (sign.ToString() == "-")
                {
                    
                   
                    vrijeme = utcNow.AddHours(-odmakInt).ToString("HH:mm");


                }
                else
                {
                    vrijeme = utcNow.AddHours(odmakInt).ToString("HH:mm");
                }
                Console.WriteLine($"Trenutno vrijeme u {city} je {vrijeme}");


            }
            Console.ReadLine();

        }
     
    }
}
