using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial.Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            string[] countries = { "Turkey", "Germany", "United States " };
            for (int i = 0; i < countries.Length; i++)
            {
                Console.WriteLine(countries[i]);
            }
            Console.ReadKey();
            #endregion

            #region
            int[] numbers = { 4, 5, 7, 9, 12, 16, 42, 13, 27, 40, 32, 56, 66 };
            for (int x = 0; x < numbers.Length; x++)
            {
                if (numbers[x] % 2 == 0)
                {
                    Console.WriteLine(numbers[x]);
                }
            }
            Console.ReadKey();
            #endregion

            #region
            int[] elements = new int[10];
            Console.Write("Enter 10 integers\r\n");
            for (int i = 0; i < 10; i++)
            {
                while (true)
                {
                    Console.Write($"Number {i + 1}:");
                    if(int.TryParse(Console.ReadLine(), out int element))
                        {
                           elements[i] = element;
                           break;
                        }
                    else
                    {
                        Console.WriteLine("Invalid number. Please enter integer\r\n");
                    }
                    
                }
            }
            Console.WriteLine("Even numbers greater than 10\r\n");
            foreach(int elem in elements)
            {
                if(elem>10 && elem%2==0)
                {
                    Console.WriteLine(elem);
                }
            }
            Console.ReadKey();
            #endregion
        }
    }
}
