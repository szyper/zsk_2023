namespace _7_tablice_2
{
  internal class Program
  {
    static void Main(string[] args)
    {
      int[,] ints = new int[2, 3];

      for (int i = 0; i < ints.GetLength(0); i++)
      {
        for (int j = 0; j < ints.GetLength(1); j++)
        {
          Console.Write($"ints[{i},{j}]={ints[i,j]} ");
        }
        Console.WriteLine();
      }

      Console.WriteLine(ints.GetLength(0)); //2
      Console.WriteLine(ints.GetLength(1)); //3
      //Console.WriteLine(ints.GetLength(2)); 
      Console.WriteLine();

      double[,,] cube = new double[2, 2, 2];
      for (int i = 0; i < cube.GetLength(0); i++)
      {
        Console.WriteLine($"cube[{i}]");

        for (int j = 0; j < cube.GetLength(1); j++)
        {
          Console.WriteLine($"\tcube[{i},{j}]");
          for (int k = 0; k < cube.GetLength(2); k++)
          {
            Console.Write($"\t\tcube[{i},{j},{k}]={cube[i, j, k]} ");
          }
          Console.WriteLine();
        }
        Console.WriteLine();
      }
      Console.WriteLine();


      int[,] matrix = new int[,] { {1, 2, 3}, {4, 5, 6 }, {7, 8, 9 } };
      for (int i = 0; i < matrix.GetLength(0); i++)
      {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
          Console.Write($"matrix[{i},{j}]={matrix[i, j]} ");
        }
        Console.WriteLine();
      }
      Console.WriteLine();

      double[,,] cube1 = new double[,,] { { {1.0, 2.0 }, {3.0, 4.0 } }, { {5.0, 6.0 }, {7.0, 8.0 } } };
      for (int i = 0; i < cube1.GetLength(0); i++)
      {
        Console.WriteLine($"cube1[{i}]");

        for (int j = 0; j < cube1.GetLength(1); j++)
        {
          Console.WriteLine($"\tcube1[{i},{j}]");
          for (int k = 0; k < cube1.GetLength(2); k++)
          {
            Console.Write($"\t\tcube1[{i},{j},{k}]={cube1[i, j, k]} ");
          }
          Console.WriteLine();
        }
        Console.WriteLine();
      }
      Console.WriteLine();
    }
  }
}
