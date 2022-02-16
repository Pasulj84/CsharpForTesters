using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpForTesters._01_Wstep
{
    public class Metody
    {
        public static void Main(string[] args)
        {
            double wynik = CalculatePrice(123, 0.23);
            Console.WriteLine(wynik);
            double max = MaxFrom(10, 17, 24);
            Console.WriteLine(max);
            Pub("Hobbit", "JR.Tolkien", "Wydawnictwo X");
            bool c = validateSumWithDiscount(1, 123, 0.23, 195);
            Console.WriteLine(c);
            int d = GetQuadrant(-3, 4);
            Console.WriteLine(d);

        }

        public static double CalculatePrice(int price, double discount)
        {
            double e = price - (price * discount);
            return Math.Round(e);
        }

        public static double MaxFrom(double a, double b, double c)
        {
            double rezu = 0;

            if (a > b)
            {
                rezu = a;                  
            }
            else
            {
                rezu = b;
            }
            if (rezu > c)
            {
                return rezu;
            }
            else
            {
                return c;
            }
        }

        public static void Pub(string title, string author, string publisher)
        {
            Console.WriteLine($"{title}, autorstwa {author} wydany przez {publisher}");
        }

        public static bool validateSumWithDiscount(int pcs, double price, double discount, double expectedSum)
        {
            double wynik = pcs * price - (pcs * price * discount); 

            if (Math.Round(wynik) != expectedSum)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static int GetQuadrant(double x, double y)
        {
            int result = x switch
            {
                _ when x > 0 && y > 0 => 1,
                _ when x > 0 && y < 0 => 2,
                _ when x < 0 && y < 0 => 3,
                _ when x < 0 && y > 0 => 4,
                _ => 0
            };
            return result;
        }
    }
}
