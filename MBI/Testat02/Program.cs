using System;

namespace Testat2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            Console.WriteLine("i = " + num);

            Console.ReadLine();

            Console.WriteLine("Bitte eine Zahl eingeben und mit Enter bestätigen");
            string text = Console.ReadLine();
            Console.WriteLine("Eingegebene Zahl : " + text);
            Console.ReadLine();


            Console.WriteLine("Bitte eine Zahl eingeben");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Eingegebene Zahl " + num2); 




            Console.ReadLine();



        }
    }
}
