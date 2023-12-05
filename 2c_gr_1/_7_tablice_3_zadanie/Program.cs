namespace _7_tablice_3_zadanie
{
  internal class Program
  {
    static void Main(string[] args)
    {
      ReadNumber();
    }

    static int ReadNumber()
    {
      int number;

      while (true)
      {
        Console.Write("Podaj lczbę całkowitą dodatnią:");
        string? input = Console.ReadLine();

        if (input == "q")
        {
          Console.WriteLine("Zakończono program");
          Environment.Exit(0);
        }

        bool success = int.TryParse(input, out number);

        if (success && number > 0) 
        {
          return number;
        }
        else
        {
          Console.WriteLine("Podana wartość nie jest poprawną liczbą dodatnią. Spróbuj ponownie lub wpisz qm aby zakończyć program");
        }
      }
    }
  }
}
