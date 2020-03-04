using System;

namespace Testat4
{
    class Program
    {
        static void Main(string[] args)
        {
			double h = 1.5;
			double b = 2;
			double t = 1.75;
			double vol = 0;
			vol = h * b * t;

            Console.WriteLine("\nAufgabe 4");
			Console.WriteLine("Volumen = " + vol + " m^3");
            double al = 2700;
            double stahl = 7850;
            double holz = 690;

            double masse = 0;
            masse = al * vol;
            Console.WriteLine("Berechnete Masse für Aluminium = " + masse + "kg");

            masse = stahl * vol;
            Console.WriteLine("Berechnete Masse für Stahl = " + masse + "kg");

            masse = holz * vol;
            Console.WriteLine("Berechnete Masse für Holz = " + masse + "kg");

        }
	}
}
