using CSharpTutorial.Classes.Core.Helpers;

namespace CSharpTutorial.Classes.Core.Domains.Persons
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public double Height { get; set; }
        public  double Weight { get; set; }

        public Person()
        {

        }

        public Person (string firstName, string lastName,int age, double height, double weight)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Height = height;
            Weight = weight;
        }

        public double GetBodyMassIndex()
        {
            return HumanHelper.GetBodyMassIndex(Height, Weight);
        }

    }
}
