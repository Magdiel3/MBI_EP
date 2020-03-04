using System;
using System.Linq;

namespace Aufgabe9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nAufgabe 9");
            int[] date = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            int[] temp = { 17, 17, 17, 18, 21, 23, 16, 13, 11, 13, 13, 13, 15 };

            double sum = 0;
            double average = 0;
            for (int i = 0; i < temp.Length; i++)
            {
                sum += temp[i];
            }
            average = sum / 13;

            Console.WriteLine("Durchschnittstemperatur ist " + average);

            int max = (int)temp.Max();
            int min = (int)temp.Min();
            Console.WriteLine("Maximale Temperatur ist " + max);
            Console.WriteLine("Minimale Temperatur ist " + min);
            Console.WriteLine("+---------------+---------------+");
            Console.WriteLine("| Datensatz\t| Temperatur\t|");
            Console.WriteLine("+---------------+---------------+");

            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine("| " + date[i] + "\t\t" + "| " + temp[i] + "\t\t" + "|");
                Console.WriteLine("+---------------+---------------+");
            }
        }
    }
}
