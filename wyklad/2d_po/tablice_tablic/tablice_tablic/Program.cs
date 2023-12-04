using System;

namespace tablice_tablic
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // int[,] ints = new int[,] { { 1, 2, 3 } };
            int[][] ints = new int[2][];
            ints[0] = new int[3];
            ints[1] = new int[2];

            ints[0][0] = 1;
            ints[0][1] = 2;
            ints[0][2] = 3;

            ints[1][0] = 4;
            ints[1][1] = 5;
            
            for (int i = 0; i < ints.Length; i++)
            {
                for (int j = 0; j < ints[i].Length; j++)
                {
                    //Console.Write("test ");
                    Console.Write($"{ints[i][j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            
            foreach (int[] i in ints)
            {
                // Console.WriteLine(i); //System.Int32[]
                foreach (int j in i)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}