using Tyuiu.MamatkulovFO.Sprint6.Task7.V3.Lib;

namespace Tyuiu.MamatkulovFO.Sprint6.Task7.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var service = new DataService();
            string filePath = @"Sprint6Task7/InPutDataFileTask7V3.csv";

            try
            {
                int[,] matrix = service.GetMatrix(filePath);

                Console.WriteLine("Результат:");
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write(matrix[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            Console.ReadKey();
        }
    }
}