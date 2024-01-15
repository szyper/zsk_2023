//using _10_1_klasy.classes;

namespace _10_1_klasy
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }

        public string GetData()
        {
            return "Imię i nazwisko: " + FirstName + " " + LastName + ", wzrost: " + Height + "cm, waga: " + Weight + "kg";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Console.WriteLine(person.GetData());
        }
    }
}
