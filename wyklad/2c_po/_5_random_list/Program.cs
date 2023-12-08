namespace _5_random_list
{
  internal class Program
  {
    static void Main(string[] args)
    {
      List<int> list = new List<int>() { 2, 3, 4};

      Console.WriteLine(list.Count);

      Random rnd = new Random();
      for (int i = 0; i < 10; i++)
      {
        list.Add(rnd.Next(1, 10 + 1));
      }

      foreach (int i in list)
      {
        Console.Write($"{i} ");
      }

      Console.WriteLine("\n{0}",list.Count);

      List<int> listDivBy2 = divisibleBy2(list);

      foreach (int i in listDivBy2)
      {
        Console.Write($"{i} ");
      }
      Console.WriteLine();

      int choice = 0;

      do
      {
        Console.WriteLine("1. Wyświetlić listę liczb podzielnych przez 2");
        Console.WriteLine("2. Wyświetlić listę liczb nieparzystych");
        Console.WriteLine("3. Wyświetlić listę liczb posortowanych rosnąco");
        Console.WriteLine("4. Wyświetlić listę liczb posortowanych malejąco");
        Console.WriteLine("5. Wyjść z programu");

        Console.Write("Podaj swój wybór:");
        choice = int.Parse(Console.ReadLine());
        //Environment.Exit(choice);

        switch (choice)
        {
          case 1:
            List<int> divisible = divisibleBy2(list);
            Console.WriteLine("Lista liczb podzielnych przez 2:");
            foreach (int i in divisible)
            {
              Console.Write($"{i} ");
            }
            Console.WriteLine();
            break;
        }
      }
      while (choice != 5);

      
    }

    static List<int> divisibleBy2(List<int> list)
    {
      List<int> result = new List<int>();

      foreach (int i in list)
      {
        if (i % 2 == 0)
        {
          result.Add(i);
        }
      }
      return result;
    } 
  }
}
