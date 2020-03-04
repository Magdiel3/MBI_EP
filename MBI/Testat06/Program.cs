using System;

namespace Testat06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nAufgabe 5");
            Console.WriteLine("Bitte das Alter von Student 1 eingeben und mit Enter bestätigen :");
            int alter1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bitte das Alter von Student 2 eingeben und mit Enter bestätigen :");
            int alter2 = Convert.ToInt32(Console.ReadLine());
            if (alter1 > alter2)
            {
                Console.WriteLine("Student 1 ist älter als Student 2");
            }
            else if (alter1 < alter2)
            {
                Console.WriteLine("Student 1 ist jünger als Student 2");
            } else {
                Console.WriteLine("Student 1 ist die selbe Älte als Student 2");
            }

        }
    }
}
