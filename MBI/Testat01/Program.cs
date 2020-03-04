using System;

namespace Testat01
{
    class Program
    {
        static void Main(string[] args)
        {
            printAufgabe("1.1");
            Console.WriteLine("Hallo Welt");
        
            printAufgabe("1.2");
            
            String name = "Max Mustermann";

            Console.WriteLine("Bitte Name eingeben und mit Enter bestätigen:");
            name = Console.ReadLine();
            Console.WriteLine("Eingegebene Name: " + name);

            void printAufgabe(String s)
            {
                Console.WriteLine("\n\nAufgabe " + s);
            }
        }
    }
}
