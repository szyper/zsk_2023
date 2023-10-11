namespace project_4_2
{
  internal class Program
  {
    static void Main(string[] args)
    {
      string input;
      string[] numbers;
      double n1=0, n2=0, n3=0;

      do
      {
        Console.Write("Podaj trzy wartości oddzielone znakiem przecinka:");
        input = Console.ReadLine();
        numbers = input.Split(',');
        if (numbers.Length == 3)
        {
          n1 = double.Parse(numbers[0]);
          n2 = double.Parse(numbers[1]);
          n3 = double.Parse(numbers[2]);
        }
        
      }while(numbers.Length != 3 || (n1 + n2 <= n3) || (n2 + n3 <= n1) || (n1 + n3 <= n2));

      double p = (n1 + n2 + n3) / 2;
      double area = Math.Sqrt(p * (p - n1) * (p - n2) * (p - n3));
      Console.OutputEncoding = System.Text.Encoding.Unicode;
      Console.WriteLine($"Pole trójkąta wynosi: {area:F2}cm\u00B2");

    }
  }
}