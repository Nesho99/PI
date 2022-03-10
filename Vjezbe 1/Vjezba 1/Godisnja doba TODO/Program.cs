using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Godisnja_doba_TODO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite datum ");
           string  input = Console.ReadLine();
           string[] inputArr=input.Split(' ');
            string doba = "";
            int datum =int.Parse(inputArr[0]);
            switch (inputArr[1])
            {
                case "sijecan":
                    doba = "zima";
                    break;
                case "veljaca":
                    doba = "zima";
                    break;
                case "ozujak":
                    if (datum < 21)
                    {
                        doba = "zima";
                    }
                    else { doba = "proljeće"; }
                    break;
                case "travanj":
                    doba = "proljeće";
                    break;
                case "svibanj":
                    doba = "proljeće";
                    break;
                case "lipanj":
                    if(datum < 21) { doba = "proljeće"; } else { doba = "ljeto"; } 
                    break;
                case "srpanj":
                    doba = "ljeto";
                    break;
                case "kolovoz":
                    doba = "ljeto";
                    break;
                case "rujan":
                    if (datum < 23) { doba = "ljeto"; } else { doba = "jesen"; }
                    break;
                case "listopad":
                    doba = "jesen";
                    break;
                case "studeni":
                    doba = "jesen";
                    break;
                case "prosinac":
                    if (datum < 21) { doba = "jesen"; } else { doba = "zima"; }
                    break;
                default:
                    break;
                  
            }
            Console.WriteLine($"Datum {input} je u godišnjem dobu {doba}");
            Console.ReadLine();




        }
    }
}
