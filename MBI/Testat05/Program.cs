using System;

namespace program
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("\nAufgabe 5");
            Console.WriteLine("Bitte einen Radius eingeben une mit Enter bestätigen :");
            double radius = Convert.ToDouble(Console.ReadLine());
            double pi;
            pi = Math.PI ;
            double durchmesser, umfang, fläche;
            durchmesser = 2*radius;
            umfang = pi*durchmesser;
            fläche = pi*radius*radius;

            Console.WriteLine("Für den Radius = " + Math.Round(radius,2));
            Console.WriteLine("Durchmesser = " + Math.Round(durchmesser,2));
            Console.WriteLine("Umfang = " + Math.Round(umfang,2));
            Console.WriteLine("Fläche = " + Math.Round(fläche,2));
        }
    }
}
