using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1Prob5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ex 5
Se citesc doua numere de la tastatura, x,y. Scrieti un program care va afisa cele doua valori in ordine crescatoare.
• Exemplu: citim ,9,0 Afisam : 0 9 
           */
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if (x < y)
                Console.Write(x + "," + y );
            else
                Console.WriteLine(y + "," + x );
        }
    }
}
