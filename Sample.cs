using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo_Day15
{
    class Sample
    {
        public static void toPrint<X>(X[] inputArray)
        {
            foreach (var element in inputArray)
            {
                Console.WriteLine(element);
            }
            //for (int i = 0; i < inputArray.Length; i = i + 2)
            //{
            //    Console.WriteLine(inputArray[i]);
            //}
            Console.WriteLine("----------------------------------");
        }
        public static void toPrint(int[] inputArray)
        {
            foreach (double element in inputArray) // 1, 2, 3, 4, 5
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("----------------------------------");
        }
        public static void toPrint(double[] inputArray)
        {

            foreach (double element in inputArray)//1.1, 2.2, 3.3, 4.4
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("----------------------------------");
        }
        public static void toPrint(char[] inputArray)
        {
            foreach (char element in inputArray) //'H', 'E', 'L', 'L', 'O'
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("-------------------------------------");
        }
    }
}
