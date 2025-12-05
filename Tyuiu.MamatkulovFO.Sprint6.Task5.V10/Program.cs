using Tyuiu.MamatkulovFO.Sprint6.Task5.V10.Lib;

namespace Tyuiu.MamatkulovFO.Sprint6.Task5.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var service = new DataService();
            string filePath = @"Sprint6Task5/InPutDataFileTask5V10.txt";

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