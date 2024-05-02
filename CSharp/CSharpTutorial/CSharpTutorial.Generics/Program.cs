using
    System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial.Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            //use of generic list
            List<string> fruits = new List<string>();
            fruits.Add("Apple");
            fruits.Add("Orange");
            fruits.Add("Banane");

            Console.WriteLine("Fruits: ");
            foreach (var fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
            Console.ReadKey();
            #endregion

            #region
            List<int> numbers = new List<int>();
            numbers.Add(51);
            numbers.Add(12);
            numbers.Add(13);

            Console.WriteLine("Numbers: ");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.ReadKey();
            #endregion

            #region
            Console.WriteLine("Enter the name of the fruit you want\r\n");
            string searchFruit = Console.ReadLine();

            if (fruits.Contains(searchFruit))
            {
                Console.WriteLine($"{searchFruit} is on the list.");
            }
            else
            {
                fruits.Contains(searchFruit);
                Console.WriteLine($"{searchFruit} is on the list.");
            }
            Console.ReadKey();

            #endregion
        }
    }
}
