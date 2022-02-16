using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpForTesters._03_Wyjatki
{
    public class RzucanieWyjatkow
    {
        public static void Main(string[] args)
        {
            int[] arr1 = new int[0];
            int[] arr2 =  { 1, 11, 3, 4, 9 };
            //arr2 = { 1, 11, 3, 4, 9 };
            try
            {
                Console.WriteLine(GetMax(arr1));
                Console.WriteLine(GetMax(arr2));
            }
            catch (Exception ex)
            {
                if (arr.Length == 0)
                {
                    throw new Exception("Treść wyjątku");
                }
            }
        }

        public static double GetMax(int[] arr)
        {
            try {
                double max = arr[0];
                for (int i = 0; i < arr.Length; i++)
                {

                    if (arr[i] > max)
                    {
                        max = arr[i];
                    }
                }

                return max;
            }
            catch (Exception ex)
            {
                if (arr.Length == 0)
                {
                    throw new Exception("Treść wyjątku");
                }
            }
            return 0;
        }
    }
}
