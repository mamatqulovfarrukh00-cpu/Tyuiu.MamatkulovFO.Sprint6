using System;
using System.IO;
using Tyuiu.MamatkulovFO.Sprint6.Task5.V10.Lib;

namespace Tyuiu.MamatkulovFO.Sprint6.Task5.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = Path.Combine("Sprint6Task5", "InPutDataFileTask5V10.txt");

            var service = new DataService();

            try
            {
                double[] numbers = service.LoadFromDataFile(filePath);

                Console.WriteLine("Ненулевые числа:");
                foreach (var num in numbers)
                {
                    Console.WriteLine(num);
                }

                Console.WriteLine($"\nВсего чисел: {numbers.Length}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            Console.ReadKey();
        }
    }
}