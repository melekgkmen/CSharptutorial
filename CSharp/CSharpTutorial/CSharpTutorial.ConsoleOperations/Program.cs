using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial.ConsoleOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region [Write single text]
            // Printing Hello World on Screen with C#
            Console.WriteLine("Hello World");
            Console.ReadKey();
            #endregion

            #region [Write text with combined]
            // Printing on the screen by taking the name and surname information into string variables with C#
            string name, surname;
            int age;
            Console.Write("Name:");
            name = Console.ReadLine();
            Console.Write("Surname:");
            surname = Console.ReadLine();
            Console.Write("Age:");
            if (!int.TryParse(Console.ReadLine(), out int number))
                Console.WriteLine("{0} {1} {2}", name, surname, number);
            Console.ReadKey();
            #endregion

            #region
            // Simple Console program that asks the user for 2 numbers and finds the sum of these numbers
            double number1, number2, result;
            Console.Write("1. number:");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2.number:");
            number2 = Convert.ToInt32(Console.ReadLine());
            result = number1 + number2;
            Console.WriteLine("Result:" + " " + result);
            Console.ReadKey();
            #endregion

            #region [Math functions with operators]
            // Simple C# Console application that prompts the user for 2 numbers and displays the sum, difference, multiplication and division of these numbers on the screen
            double numberFirst, numberSecond, total, difference, multiplication, division;
            Console.Write("Number First :");
            numberFirst = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number Second :");
            numberSecond = Convert.ToInt32(Console.ReadLine());
            total = numberFirst + numberSecond;
            difference = numberFirst - numberSecond;
            multiplication = numberFirst * numberSecond;
            division = numberFirst / numberSecond;
            Console.WriteLine("Total:" + " " + total);
            Console.WriteLine("Difference:" + " " + difference);
            Console.WriteLine("Multiplication:" + " " + multiplication);
            Console.WriteLine("Devision:" + " " + division);
            Console.ReadKey();

            #endregion
        }
    }
}
