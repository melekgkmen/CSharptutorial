using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace CSharpTutorial.VariableUsages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region [Byte, Integer, Long]
            // We add 20 to 30 and print them on the screen.
            int number1 = 20, number2 = 40;
            int totalNumber = number1 + number2;
            Console.WriteLine(totalNumber);

            byte byte1 = 155;
            byte byte2 = 155;
            int byteTotal = byte1 + byte2;
            Console.WriteLine(byteTotal);
            #endregion

            #region [Double, Float, Decimal, etc.]
            // Add 10.4 to 16.9 and print it on the screen.
            float floatNumber1 = 10.4f, floatNumber2 = 16.9f;
            float floatTotal = floatNumber1 + floatNumber2;
            Console.WriteLine(floatTotal);
            #endregion

            #region [char]
            // Print only the letter s on the screen.
            char character = 's';
            Console.WriteLine(character);
            #endregion

            #region[string]
            // Print Rabia on the screen.
            string name = "Rabia";
            Console.WriteLine(name);

            string name2 = $"Number:{totalNumber}";

            string name3 = @"Hello World!
            My name is Melek";

            string name4 = $@"Hello World!
My name is {name}";

            string name5 = $@"Hello World!{Environment.NewLine} My name is {name}";

            string name6 = "New line test.\n\rResult.15:";
            Console.WriteLine(name6);
            #endregion

            #region [Object]
            object obj = "test";
            object obj1 = 1;
            object obj2 = 1.3d;
            object obj3 = 1.5f;
            object obj4 = 1.78m;
            object obj5 = 'a';
            object obj6 = "123";
            #endregion

            #region [Conversions]
            long longTotal = (long)totalNumber;
            long longTotal2 = (Convert.ToInt64(longTotal));

            double doubleTotal = (double)floatTotal;
            #endregion

            #region
            string charString = character.ToString();
            charString = $"{character}";
            charString = "" + character;
            charString = character + string.Empty;
            charString = Convert.ToString(character);

            string stringTotal = totalNumber.ToString() + " " + character + " " + floatNumber1;

            stringTotal += totalNumber;

            stringTotal = $"{totalNumber}{character}{floatNumber1}";
            Console.WriteLine(stringTotal);

            string objText = obj.ToString();
            Console.WriteLine(objText);

            int objInteger = Convert.ToInt32(obj6);
            Console.WriteLine(objInteger);

            int objDoubleInteger = Convert.ToInt32(obj2);
            Console.WriteLine(objDoubleInteger);

            double objDoubleRound = Math.Round((double)obj2);
            Console.WriteLine(objDoubleRound);
            #endregion

            Console.ReadKey();
        }
    }
}
