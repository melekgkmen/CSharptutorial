using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharptutorial.Conditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region [Example 1]
            //We print the larger of the two entered numbers
            int number1, number2;
            Console.Write("Number 1:");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number 2:");
            number2 = Convert.ToInt32(Console.ReadLine());
            if (number1 > number2)
            {
                Console.WriteLine(number1);
            }
            else if (number1 == number2)
            {
                Console.WriteLine("numbers are equal");
            }
            else
            {
                Console.WriteLine(number2);
            }
            Console.ReadKey();
            #endregion


            #region [Example 2]
            //Driving license application based on age
            int age;
            Console.Write("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("You can get a drivers license");
            }
            else
            {
                Console.WriteLine("You are not old enough to get a drivers license");
            }
            Console.ReadKey();
            #endregion


            #region[Example 3]
            //We print whether the course you entered was successful or not based on your grades.
            int average;
            Console.Write("Note 1: ");
            int note1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Note 2: ");
            int note2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Note 3: ");
            int note3 = Convert.ToInt32(Console.ReadLine());
            average = (note1 + note2 + note3) / 3;
            if (average >= 50)
            {
                Console.WriteLine("Success");
            }
            else
            {
                Console.WriteLine("Unsuccessful");
            }
            Console.ReadKey();
            #endregion


            #region [Example 4]
            //Printing whether the entered year is a leap year or not.
            int year;
            Console.Write("Enter the year");
            year = Convert.ToInt32(Console.ReadLine());
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                Console.WriteLine(year + " " + "is a leap year");
            }
            else
            {
                Console.WriteLine(year + " " + "is not a leap year");
            }
            Console.ReadKey();
            #endregion


            #region [Example 5]
            //We print that it is the sixth day according to the entered day.
            Console.WriteLine("Which day ? ");
            string day = Console.ReadLine();
            switch (day)
            {
                case "Monday":
                    Console.WriteLine("1. day");
                    break;

                case "Tuesday":
                    Console.WriteLine("2. day");
                    break;

                case "Wednesday":
                    Console.WriteLine("3. day");
                    break;

                case "Thursday":
                    Console.WriteLine("4. day");
                    break;

                case "Friday":
                    Console.WriteLine("5. day");
                    break;

                case "Saturday":
                    Console.WriteLine("6. day");
                    break;

                case "":
                    Console.WriteLine("7.day");
                    break;

                default:
                    Console.WriteLine("invalid day");
                    break;
            }
            Console.ReadKey();
            #endregion
        }
    }
}
