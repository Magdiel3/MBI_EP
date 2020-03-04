using System;

namespace Aufgabe2
{
    class Program
    {
        static void Main(string[] args)
        {
            printAufgabe("2.1");
            int zahl = 1;
            Console.WriteLine("i = " + zahl);

            Console.ReadLine();
            printAufgabe("2.2");
            Console.WriteLine("Bitte eine Zahl eingeben und mit Enter bestätigen");
            string text = Console.ReadLine();
            Console.WriteLine("Eingegebene Zahl (als Text): " + text);
            Console.ReadLine();

            Console.ReadLine();
            printAufgabe("2.2");
            Console.WriteLine("Bitte eine Zahl eingeben und mit Enter bestätigen");
            zahl = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Eingegebene Zahl nach Convert.ToInt32(text): " + zahl); 
            Console.ReadLine();

            void printAufgabe(String s)
            {
                Console.WriteLine("\n\nAufgabe " + s);
            }

        }
    }
}
