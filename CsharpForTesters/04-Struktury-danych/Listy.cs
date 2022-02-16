using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpForTesters._04_Struktury_danych
{
    public class Listy
    {
        public static void Main(string[] args)
        {
            List<string> Star = new List<string>()
            {
                "Han Solo",
                "Luke Skywalker",
                "Darth Vader",
                "C-3PO",
                "Leia Organa",
                "Obi-Wan Kenobi"
            };

            for (int i = 5; i >= 0; i--)
            {
                Console.WriteLine(Star[i]);
            }
        }
    }
}
