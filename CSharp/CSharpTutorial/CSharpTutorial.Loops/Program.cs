using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial.Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            //We print the profiles between 1 and 5 on the screen by increasing them one by one.
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
            #endregion


            #region
            //We print the numbers between 1 and 5 by combining them with the word Hello
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i + " " + "Hello");
            }
            Console.ReadKey();
            #endregion


            #region
            //We print the factorial of the number entered from the keyboard
            Console.Write("Enter the number you want to calculate the factorial");
            int number = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;
            if (number == 1)
            {
                Console.WriteLine("The factorial of the number 1 is 1\r\n");
            }
            else if (number < 0)
            {
                Console.WriteLine("The factorial of negative numbers is not calculated\r\n");
            }
            else
            {
                for (int x = 1; x <= number; x++)
                {
                    factorial *= x;
                }
                Console.WriteLine($"{number}! = {factorial}");
            }
            Console.ReadKey();
            #endregion

            #region
            //We print odd numbers between 1 and 100
            for (int y = 1; y <= 100; y += 2)
            {
                Console.WriteLine(y);
            }
            Console.ReadKey();
            #endregion

            #region
            //We print the sum of even numbers between 1 and 10
            int z = 1;
            do
            {
                if (z % 2 != 0)
                {
                    Console.WriteLine(z);
                }
                z++;
            }
            while (z <= 10);
            Console.ReadKey();
            #endregion


            #region
            int index = 0;
            do
            {
                if (index < 3)
                {
                    Console.WriteLine("Yellow");
                }
                index++;
            }
            while (index <= 5);
            Console.ReadKey();
            #endregion

            #region
            string[] names = { "Alice", "Bob", "Charlie" };
            foreach (string name in names)
            {
                Console.WriteLine("Hello" + " " + name);
            }
            Console.ReadKey();
            #endregion

            #region
            int sum = 0;
            int[] numbers = { 1, 15, 45, 78, 95, 62, 48, 263 };
            foreach (int n in numbers)
            {
                sum += n;
            }
            Console.WriteLine($"Sum of elements of the array :\r\n {sum}");

            double average =(double) sum / numbers.Length;

            Console.WriteLine($"Average of elements in the array:\r\n {average}");

            Console.ReadKey();

            #endregion


            #region
            try
            {
                Console.Write("Enter a number: \r\n");
                int num = int.Parse(Console.ReadLine());

                Console.WriteLine($"The number you entered: \r\n {num} ");
            }

            catch (Exception)
            {
                Console.WriteLine($"Error, you entered an invalid number");
            }
            Console.ReadKey();
            #endregion




        }
    }
}
