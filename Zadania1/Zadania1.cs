using System;

namespace Zadania
{
    public class Zadania
    {
        public static void Main(string[] args)
        {
            zad18();
        }
        public static void zad11()
        {
            double a, b, area; 
            Console.WriteLine("Podaj długość pierwszego boku: ");
            a = Double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj długość drugiego boku: ");
            b = Double.Parse(Console.ReadLine());
            area = a * b;
            Console.WriteLine("Powierzchnia Twojego prostokąta to: {0}", area);
        }

        public static void zad12()
        {
            double pi = Math.PI;
            Console.WriteLine("Program pokaże liczbę Pi z dokładnością do 5 cyfr po przecinku.");
            Console.WriteLine(Math.PI.GetType());
            Console.WriteLine(pi.ToString("G6"));
        }

        public static void zad13()
        {
            double pi = Math.PI;
            Console.WriteLine("Program pokaże liczbę Pi z dokładnością do 5 cyfr po przecinku.");
            Console.WriteLine(Math.PI.GetType());
            Console.WriteLine(Math.Sqrt(pi).ToString("G3"));
        }
        public static void zad14()
        {
            double r, area;
            Console.WriteLine("Program liczy powierzchnię od podanego r.");
            Console.WriteLine("Podaj długość promienia r: ");
            r = Double.Parse(Console.ReadLine()); 
            area = Math.PI * r * r;
            Console.WriteLine("Pole powierzchni Twojego koła to: {0}", Math.Round(area, 2));
        }

        public static void zad15()
        {
            Console.WriteLine("Program poda wynik dzielenia całkowitego dla 37 oraz 11.");
            Console.WriteLine("Wynik to: {0}", 37/11);
        }

        private static void zad16()
        {
            Console.WriteLine("Program poda reszte z dzielenia liczb całkowitych dla 37 oraz 11.");
            Console.WriteLine("Wynik to: {0}", 37%11);
        }
        private static void zad17()
        {
            double a, b;
            Console.WriteLine("Podaj dwie liczby:");
            Console.Write("Liczba a = ");
            a = Double.Parse(Console.ReadLine());
            Console.Write("Liczba b = ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Suma: {0}, różnica: {1}, iloczyn: {2}, iloraz: {3}", a+b, a-b, a*b, Math.Round(a/b, 2));
        }
        public static void zad18()
        {
            try
            {
                double a, b, area;
                Console.WriteLine("Podaj długość pierwszego boku: ");
                a = Double.Parse(Console.ReadLine());
                Console.WriteLine("Podaj długość drugiego boku: ");
                b = Double.Parse(Console.ReadLine());
                area = a * b;
                Console.WriteLine("Powierzchnia Twojego prostokąta to: {0}", area);
            }
            catch
            {
                Console.WriteLine("Błędnie podana liczba.");
            }
        }
    }
}