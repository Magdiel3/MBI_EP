using System;

namespace Aufgabe8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nAufgabe 8");
            for (int i = 1; i <= 10; i++)
            { 
              for(int j = 0; j<=10; j++)
                {
                    Console.WriteLine("{0}x{1} = {2}" , i,j,i*j);
                }
                Console.WriteLine("-------------------------------------------------------");
                }
            Console.ReadKey();
        }
    }
}
