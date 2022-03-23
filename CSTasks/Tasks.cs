using System;
using System.Linq;

namespace CSTasks
{
    public class Tasks
    {
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
            double a, b, c, delta, x1, x2;
            Console.WriteLine("Program wylicza pierwiastki równania kwadratowego które zaraz podasz.");
            Console.WriteLine("Podaj trzy liczby do równania ax^2 + bx + c:");
            Console.Write("Podaj a:");
            a = Int32.Parse(Console.ReadLine());
            Console.Write("Podaj b:");
            b = Int32.Parse(Console.ReadLine());
            Console.Write("Podaj c:");
            c = Int32.Parse(Console.ReadLine());
            delta = Math.Pow(b,2) - 4*(a*c);
            x1 = -b+Math.Sqrt(delta)/(2*a);
            x2 = -b-Math.Sqrt(delta)/(2*a);
            Console.WriteLine($"Pierwiastki Twojego równania to x1: {0} oraz x2: {1}", x1, x2);
        }

        public static void zad24()
        {
            double a, b, c, x;
            Console.WriteLine("Program wylicza x z równania ax + b = c.");
            Console.WriteLine("Podaj trzy liczby do tego równania.");
            Console.Write("Podaj a:");
            a = Convert.ToDouble(Console.ReadLine());
            while (a == 0)
            {
                Console.WriteLine("A nie może się równać 0, podaj inną liczbę:");
                a = Convert.ToDouble(Console.ReadLine());
                if (a != 0)
                {
                    break;
                }
            }
            Console.Write("Podaj b:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj c:");
            c = Convert.ToDouble(Console.ReadLine());
            x = (c - b) / a;
            Console.WriteLine("X jest równe: " + RoundUp(x, 2));
        }

        public static void zad25()
        {
            int a,b;
            Random r = new Random();
            a = r.Next(0, 9);
            Console.WriteLine("Zagramy w zgadywankę, podaj liczbę całkowitą z przedziału <0,9>");
            b = Convert.ToInt32(Console.ReadLine());
            while (a != 0)
            {
                Console.WriteLine("Nope, podaj kolejna liczbę.");
                b = Convert.ToInt32(Console.ReadLine());
                if (a == b)
                {
                    Console.WriteLine("Gratulacje lampucero, zgadłeś/aś/oś.");
                    break;
                }
            }
        }

        public static void zad31()
        {
            int y,i;
            Console.WriteLine("Wyliczę teraz wartości zdania: y = 3x gdzie x={0,10}.");
            for ( i = 0; i <= 10; i++)
            {
                y = 3 * i;
                Console.WriteLine("Wynik zdania y = 3 * x dla x równego {0} wynosi: {1}", i.ToString(), y.ToString());
            }

        }

        public static void zad32()
        {
            int y, i;
            i = 0;
            do
            {
                y = 3 * i;
                Console.WriteLine("Wynik zdania y = 3 * x dla x równego {0} wynosi: {1}", i.ToString(), y.ToString());
                i++;
            } while (i < 10);
        }

        public static void zad311()
        {
            int sum, i;
            sum = 0;
            i = 0;
            do
            {
                if ( i % 2 == 0)
                {
                    sum = sum + i;
                }

                i++;
            } while (i <= 100);
            Console.WriteLine("Suma wynosi: {0}", sum);
        }

        public static void zad316()
        {
            Random r = new Random();
            int max, min, avr;
            int[] zbior = new int[5];
            for (int i = 0; i < 5; i++)
            {
                zbior[i] = r.Next(0, 99);
            }

            max = zbior.Max();
            min = zbior.Min();
            avr = (int)zbior.Average();
            Console.WriteLine("Program wyliczy maks, min, avr z 5 paralosowych liczb:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Liczby to: {0}", zbior[i]);
            }
            Console.WriteLine("Liczba największa to: {0}, najmniejsza to: {1}, średnia arytmetyczna wynosi: {2}", max, min, avr);
        }

        public static void zad319()
        {
            int i, j;
            for (i = 1; i <= 10; i++)
            {
                Console.Write("{0}  ", i);
                for (j = 1; j <= 10; j++)
                {
                    Console.Write("{0}  ", i * j);
                }
                Console.Write("\n");
            }
        }

        public static void zad322()
        {
            char znak;

            for (znak = 'A'; znak <= 'Z'; znak++)
            {
                Console.WriteLine("Upper to: {0}", znak);
            }

            for (znak = 'Z'; znak >= 'A'; znak--)
            {
                Console.WriteLine("Upper to: {0}", znak);
            }
        }

        public static void zad325()
        {
            int a, b, suma = 0;
            for (int i = 1000; i < 9999; i++)
            {
                a = Convert.ToInt32(String.Format("{0}{1}",i/1000,(i/100)%10));
                b = Convert.ToInt32(String.Format("{0}{1}", (i / 10)%10, i  % 10));
                if (i == Convert.ToInt32(Math.Pow(a,2)) + Convert.ToInt32(Math.Pow(b,2)))
                {
                    Console.WriteLine("Liczba dla której ta CIEKAWA zależność działa: " + i);
                    suma++;
                }
            }
            Console.WriteLine("Ilość takich liczb: " + suma);
        }

        public static void zad41()
        {
            int[] dane = new int[10];
            for (int i = 0; i <= 9; i++)
            {
                dane[i] = i;
                Console.WriteLine("Komórka: {0}, wartość {1}", i, dane[i]);
            }
        }
        
        public static void zad42()
        {
            int[] dane = new int[10];
            int j = 9;
            for (int i = 0; i <= 9; i++)
            {
                dane[i] = j;
                Console.WriteLine("Komórka: {0}, wartość {1}", i, dane[i]);
                j--;
            }
        }
        public static void zad43()
        {
            int n = 10, i, j;
            int[,] macierz = new int[n,n];
            for (i = 0; i < n; i++)
            {
                for ( j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        macierz[i, j] = 1;
                    }
                    else
                        macierz[i, j] = 0;
                }
            }
            for ( i = 0; i < n; i++)
            {
                for ( j = 0; j < n; j++)
                {
                    Console.Write(macierz[i,j] + " ");
                }
                Console.WriteLine();
            }

            //nie działa to głupi debilu
        }
        public static void zad44()
        {
            int n = 10, i, j;
            int[,] macierz = new int[n,n];
            for (i = 0; i < n; i++)
            {
                for ( j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        macierz[i, j] = i;
                    }
                    else
                        macierz[i, j] = 0;
                }
            }
            for ( i = 0; i < n; i++)
            {
                for ( j = 0; j < n; j++)
                {
                    Console.Write(macierz[i,j] + " ");
                }
                Console.WriteLine();
            }

            //nie działa to głupi debilu
        }
        public static void Main()
        {
            zad44();
        }

        public static double RoundUp(double input, int places)
        {
            double multiplier = Math.Pow(10, Convert.ToDouble(places));
            return Math.Ceiling(input * multiplier) / multiplier;
        }
    }
}