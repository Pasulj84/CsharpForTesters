using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpForTesters._01_Wstep
{
    public class Petle
    {
        public static void Main(string[] args)
        {
            int value = 102;

            if (value < 0 || value > 100)
            {
                Console.WriteLine("To nie jest akceptowalna wartość zmiennej value");
            }
            else{
                Console.WriteLine("Pomiar wynosi value");
            }

            double input = 3.5;
            string jakiePiwo = (input >= 4) ? "mocne" : "słabe";
/*
            if (input >= 4) ? 
            {
                jakiePiwo = "mocne";
            }
            else
            {
                jakiePiwo = "słabe";
            }*/
            Console.WriteLine(jakiePiwo);

            int dayOfTheWeek = 4;

            switch (dayOfTheWeek)
            {
                case 1:
                    Console.WriteLine("Poniedziałek");
                    break;
                case 2:
                    Console.WriteLine("Wtorek");
                    break;
                case 3:
                    Console.WriteLine("Środa");
                    break;
                case 4:
                    Console.WriteLine("Czwartek");
                    break;
                case 5:
                    Console.WriteLine("Piątek");
                    break;
                case 6:
                    Console.WriteLine("Sobota");
                    break;
                case 7:
                    Console.WriteLine("Niedziela");
                    break;
                default:
                    Console.WriteLine("Zla data");
                    break;


            }
        }
    }
}
