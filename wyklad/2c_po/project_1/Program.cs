namespace project_1
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.OutputEncoding = System.Text.Encoding.Unicode;
      //Console.OutputEncoding = System.Text.Encoding.Default;
      Console.WriteLine("②");

      Console.WriteLine("\x263A");
      Console.WriteLine("☺");

      //char letter = 'a';

      char letter = (char)97;
      Console.WriteLine(letter); //a

      Console.WriteLine("\x61"); //a

      //pole trójkąta => wzór Herona
      Console.Clear();

      /*
      double a, b, c;

      Console.Write("a:");
      a = double.Parse(Console.ReadLine());

      Console.Write("b:");
      b = double.Parse(Console.ReadLine());

      Console.Write("c:");
      c = double.Parse(Console.ReadLine());

      if (a + b > c && a + c > b && b + c > a)
      {
        double p = (a + b + c) / 2;
        double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        Console.WriteLine($"Pole trójkąta wynosi: {area:F2}cm^2");
      }
      else
      {
        Console.WriteLine("Podane długości boków nie zbudują trójkąta");
      }
      */

      //#######################################################


      /*
      double a, b, c;

      do
      {
        Console.Clear();
        Console.Write("a:");
        a = double.Parse(Console.ReadLine());

        Console.Write("b:");
        b = double.Parse(Console.ReadLine());

        Console.Write("c:");
        c = double.Parse(Console.ReadLine());
      } while (a + b <= c || a + c <= b || b + c <= a);

      double p = (a + b + c) / 2;
      double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
      Console.WriteLine($"Pole trójkąta wynosi: {area:F2}cm^2");

      //pole trójkąta wzór Herona v.2

      Console.Clear();

      double number1, number2, number3;
      Console.Write("Podaj trzy liczby odzielone spacjami:");
      string input = Console.ReadLine();
      string[] numbers = input.Split(' ');

      //Console.WriteLine(numbers[0]);
      //number1 = Convert.ToDouble(numbers[0]);
      number1 = double.Parse(numbers[0]);
      number2 = double.Parse(numbers[1]);
      number3 = double.Parse(numbers[2]);

      try
      {

      }catch(Exception ex)
      {

      }
      */


      Console.WriteLine(Environment.OSVersion);


      Console.WriteLine(Environment.Version);
      Console.WriteLine(Environment.UserName);
      Console.WriteLine(Environment.UserDomainName);
      Console.WriteLine(Environment.MachineName);

      Console.WriteLine(Environment.CurrentDirectory);



      Console.ReadKey();
    }
  }
}