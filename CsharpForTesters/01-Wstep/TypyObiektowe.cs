using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpForTesters._01_Wstep
{
    public class TypyObiektowe
    {
        public static void Main(string[] args)
        {
            string a = "Tester był \"bardzo\" ucieszony z powodu notorycznego ignorowania raportów błędów przez developera";
            Console.WriteLine(a);
            string name = "Dominik";
            int age = 38;
            if (age < 18)
            {
                Console.WriteLine($"{name} jest niepełnoletni");
            }
            else
            {
                Console.WriteLine($">{name} jest pełnoletni");
            }
            
            
            string b = "Kamil Ślimak";
            char[] charArray = b.ToCharArray();
            char[] c = new char[12];
            string d;
            int j = 0;

            for(int i = 11; i >= 0; i--)
            {
                c[j] = charArray[i];
                j++;
            }
            string reversed = new string(c);
            Console.WriteLine(reversed);
        }
    }
}
