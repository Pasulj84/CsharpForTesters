using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpForTesters._03_Wyjatki
{
    public class Wyjatki
    {
        public static void Main(string[] args)
        {
            try
            {
                var a = 10;
                var b = 0;

                var c = a / b;

                Console.WriteLine(c);

                
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine("A to się powinno wydrukować niezależnie od wszystkiego");
        }
    }
}
