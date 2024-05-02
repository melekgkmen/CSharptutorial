using CSharpTutorial.Classes.Core.Domains.Persons;
using CSharpTutorial.Classes.Core.Domains.Students;
using CSharpTutorial.Classes.Core.Helpers;
using System;
using System.Drawing;

namespace CSharpTutorial.Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region [Static Methods]
            int total = MathHelper.GetSum(1, 2);
            int total2 = MathHelper.GetSum(50, 45, 85);
            double average = MathHelper.GetAverage(100, 85, 92);
            Console.WriteLine(total);
            Console.WriteLine(total2);
            Console.WriteLine(average);
            Console.WriteLine("##################");
            #endregion

            #region [Class Usage-Student]
            Student student = new Student()
            {
                FirstName = "Melek",
                LastName = "Gökmen"
            };
            student.SetMathGrade(100,85,78);
            student.SetAddress("İnönü Mah.");

            Student student2 = new Student("Rabia", "Soğukpınar");
            student2.SetMathGrade(30, 48, 57);

            Console.WriteLine(student.GetAverageMath());
            Console.WriteLine(student2.GetAverageMath());

            Console.WriteLine(student2.GetAdress());
            Console.WriteLine("#############");
            #endregion

            #region [Class Usage - Person]
            Person person = new Person("Melek", "Gökmen", 23, 75d, 1.8d);
            double personBodyMassIndex = person.GetBodyMassIndex();
            Console.WriteLine(personBodyMassIndex);

            Person person2 = new Person("Serhat","Soğukpınar",30,72d,1.8d);
            double person2BodyMassIndex = person2.GetBodyMassIndex();
            Console.WriteLine(person2BodyMassIndex);
            #endregion

            Console.ReadKey();
        }
    }
}