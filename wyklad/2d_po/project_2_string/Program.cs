namespace project_2_string
{
  internal class Program
  {
    static void Main(string[] args)
    {
      //a = float.Parse("4");

      /*
      float a;
      a = float.Parse(Console.ReadLine());
      Console.WriteLine($"Bok a: {a}, pole: {a*a}cm^2");

      Console.Clear();
      */


      double n1, n2, n3;
      string input;
      string[] numbers;

      do
      {
          Console.Clear();
          Console.Write("Podaj trzy długości boków, rodziel wartości spacjami:");
          input = Console.ReadLine();
          numbers = input.Split(' ');
          n1 = double.Parse(numbers[0]);
          n2 = double.Parse(numbers[1]);
          n3 = double.Parse(numbers[2]);
      } while (numbers.Length != 3 || (n1 + n2 <= n3) || (n1 + n3 <= n2) || (n2 + n3 <= n1));

      double p = 0.5 * (n1 + n2 + n3);
      double area = Math.Sqrt(p * (p - n1) * (p - n2) * (p - n3));
      Console.WriteLine($"Pole trójkąta wynosi: {area:F2}cm");
      //dokończyć 2 z indeksem górnym w Unicode
    }
  }
}