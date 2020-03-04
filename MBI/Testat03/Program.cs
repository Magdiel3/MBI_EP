using System;

namespace Testat03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aufgabe 3");

            double x = 3.5, y = 4.6, ergebnis;

            Console.WriteLine("x = " + x + " y = " + y);
            Console.Write("Das Ergebnis der Addition x + y = ");
            ergebnis = x + y;
            Console.WriteLine(ergebnis);
			

            Console.Write("Das Ergebnis der Substraktion x - y = ");
            ergebnis = x - y;
            Console.WriteLine(ergebnis);

            Console.Write("Das Ergebnis der Multiplikation x * y = ");
            ergebnis = x + y;
            Console.WriteLine(ergebnis);

            Console.Write("Das Ergebnis der Division x / y = ");
            ergebnis = x / y;
            Console.WriteLine(ergebnis);
        }
    }
}
