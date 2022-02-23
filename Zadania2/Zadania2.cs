using System;

namespace Zadania2
{
    public class Zadania2
    {
        public static void Main()
        {
            zad22();
        }

        public static void zad21()
        {
            int a, b, c;
            Console.WriteLine("Podaj trzy liczby:");
            a = Int32.Parse(Console.ReadLine());
            b = Int32.Parse(Console.ReadLine());
            c = Int32.Parse(Console.ReadLine());
            if (a*a + b*b == c*c)
            {
                Console.WriteLine("Trzy podane liczby tworzą trójkę pitagorejską.");
            }
            else
            {
                Console.WriteLine("Trzy podane liczby nie tworzą trójki pitagorejskiej.");
            }
        }

        public static void zad22()
        {
            int a, b, c;
            Console.WriteLine("Program wylicza pierwiastki równania kwadratowego które zaraz podasz.");
            Console.WriteLine("Podaj trzy liczby do równania ax^2 + bx + c:");
            a = Int32.Parse(Console.ReadLine());
            b = Int32.Parse(Console.ReadLine());
            c = Int32.Parse(Console.ReadLine());
        }
    }
}