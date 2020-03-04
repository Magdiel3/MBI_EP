using System;

namespace Aufgabe7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nAufgabe 7");
            Console.WriteLine("Bitte eine Ganzzahl, deren Teilbarkeit getestet werden soll, eingeben und mit Enter bestätigen: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Bitte einen ganzzahligen Teiler eingeben und mit Enter bestätigen: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if(num1 % num2 == 0)
            {

                Console.WriteLine(num1 +  " ist ohne Rest durch " + num2 + " teilbar");       
            }
            else
            {
                Console.WriteLine(num1 + " ist nicht durch " + num2 + " teilbar"); 
            }
        }
    }
}
