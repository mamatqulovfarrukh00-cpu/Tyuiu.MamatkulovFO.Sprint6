using System;

namespace Tyuiu.MamatkulovFO.Sprint6.Task3.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            var ds = new Tyuiu.MamatkulovFO.Sprint6.Task3.V10.Lib.DataService();

            int[,] matrix = {
                {-17, 6, -19, 6, -13},
                {-19, 3, 12, -11, 19},
                {-20, 11, 9, 19, -19},
                {-20, 10, -9, 17, 9},
                {-4, 9, -8, 13, -8}
            };

            Console.WriteLine("Boshlang'ich massiv:");
            PrintMatrix(matrix);

            int[,] result = ds.Calculate(matrix);

            Console.WriteLine("\nO'zgartirilgan massiv (5-chi qatorda juftlar 0 ga aylandi):");
            PrintMatrix(result);

            Console.ReadKey();
        }

        static void PrintMatrix(int[,] mat)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"{mat[i, j],4} ");
                }
                Console.WriteLine();
            }
        }
    }
}