using _10_1_klasy.classes;

namespace _10_1_klasy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Console.WriteLine(person.GetData());

            Student s1 = new Student();
            s1.StudentNumber = "12345";

            Teacher t1 = new Teacher();
            t1.Subjects = new List<string> { "Informatyka", "Matematyka" };

            t1.GetAllSubjects();

            /*
            foreach (var item in t1.Subjects)
            {
                Console.WriteLine(item);
            }
            */

            person.FirstName = "Janusz";
            //Console.WriteLine(person.FirstName);
            Console.WriteLine(person.GetData());
        }
    }
}
