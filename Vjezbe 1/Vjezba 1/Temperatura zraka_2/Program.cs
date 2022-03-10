using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatura_zraka_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string glavni = "13,2|13,6|-|14,8|15,1|-|14,2|13,7";
            string rezervni = "286,45|286,85|287,25|288,05|288,35|287,95|287,45|286,95";
            double avg = 0;
            int index=0;
            string[] glavniArr=glavni.Split('|');
            string[] rezervniArr=rezervni.Split('|');
            foreach (string  item in glavniArr)
            {
                double rez;
                if (item == "-")
                {
                    string s=rezervniArr[index];
                    s=s.Replace(',', '.');
                     rez=Double.Parse(s)-273.15;
                    Console.WriteLine($"{rez} C");



                }
                else
                {
                     rez = double.Parse(item.Replace(',', '.'));
                    Console.WriteLine($"{rez} C");
                }
                avg += rez;
                   
            index++;
            }
            avg = avg / glavniArr.Length;
            Console.WriteLine($"Prosjecna temepratura je {avg} C");
            Console.ReadLine();

        }
    }
}
