using System;
using System.Collections.Generic;
using System.Linq;

namespace Aufgabe9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nAufgabe 10");
            List<int> temps = new List<int>();
            int[] temp = { 17, 17, 17, 18, 21, 23, 16, 13, 11, 13, 13, 13, 15 };

            for (int i = 0; i < temp.Length; i++)
            {
                temps.Add(temp[i]);
            }

            auswertungsprozedur(temps);
            Random rnd = new Random();

            for(int i = 0; i < 20; i++)
            {
                temps.Add((int)rnd.Next(-4,32));
            }

            auswertungsprozedur(temps);

            void auswertungsprozedur(List<int> list)
            {
                double sum = 0;
                double average = 0;
                sum = list.Sum();
                average = sum / 13;
                DateTime time = DateTime.Now; 
                Console.WriteLine("Auswertung vom " + time.ToLongDateString() + ", " + time.ToLongTimeString() + " und " + time.Millisecond + "ms.");
                Console.WriteLine("#Messwerte = " + temps.Count());
                Console.WriteLine("Durchschnittstemperatur ist " + Math.Round(average,2));
                int max = (int)list.Max();
                int min = (int)list.Min();
                Console.WriteLine("Maximale Temperatur ist " + max);
                Console.WriteLine("Minimale Temperatur ist " + min);
                Console.WriteLine("*********************************************************");
            }
        }
    }
}
