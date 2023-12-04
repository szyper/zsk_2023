using System;

namespace tablice_7_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[,] ints = new int[4, 3];
            Console.WriteLine(ints.Rank); //2
            Console.WriteLine(ints.GetLength(0)); //4
            Console.WriteLine(ints.GetLength(1)); //3
            //Console.WriteLine(ints.GetLength(2)); //error
            Console.WriteLine();

            int[,,] cubs = new int[2, 3, 4];
            for (int i = 0; i < cubs.GetLength(0); i++)
            {
                Console.WriteLine($"cubs[{i}]");
                for (int j = 0; j < cubs.GetLength(1); j++)
                {
                    Console.WriteLine($"\tcubs[{i},{j}]");
                    for (int k = 0; k < cubs.GetLength(2); k++)
                    {
                        Console.Write($"\t\tcubs[{i},{j},{k}] = {0} ", cubs[i,j,k]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // int[,] matrix = new int[2, 3];
            int[,] matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"matrix[{i}, {j}] = {matrix[i,j]} ");
                }
                Console.WriteLine();
            }

            double[,,] cube1 = new double[,,] { {{1.0, 2.0, 3.0}, {4.0, 5.0, 6.0}}, {{7.0, 8.0, 9.0},{10.0, 11.0, 12.0}}};
            for (int i = 0; i < cube1.GetLength(0); i++)
            {
                Console.WriteLine($"cube1[{i}]");
                for (int j = 0; j < cube1.GetLength(1); j++)
                {
                    Console.WriteLine($"\tcube1[{i},{j}]");
                    for (int k = 0; k < cube1.GetLength(2); k++)
                    {
                        Console.Write($"\t\tcube1[{i},{j},{k}]={cube1[i,j,k]} ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            
        }
    }
}