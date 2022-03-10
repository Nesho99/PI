using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

Console.WriteLine("A=");
int A= int.Parse(Console.ReadLine());
Console.WriteLine("B=");
int B= int.Parse(Console.ReadLine());
Console.WriteLine("C=");
int C= int.Parse(Console.ReadLine());
int suma = 0;
Console.Write("Rezultat je: ");
for (int i = A; i <= B; i++)
{
    if (i%C==0)
    {
        Console.Write($"{i}, ");
        suma += i;

    }

}
Console.WriteLine($"Suma je {suma}");
Console.ReadLine();
