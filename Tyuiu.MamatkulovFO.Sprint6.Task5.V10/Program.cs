using System;
using System.IO;
using Tyuiu.MamatkulovFO.Sprint6.Task5.V10.Lib;

namespace Tyuiu.MamatkulovFO.Sprint6.Task5.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = Path.Combine("Sprint6Task5", "InPutDataFileTask5V10.txt");

            var service = new DataService();
            double[] all = service.LoadFromDataFile(filePath);
            double[] nonZero = service.FilterNonZero(all);

            Console.WriteLine("=== Все числа из файла ===");
            foreach (double x in all)
                Console.WriteLine($"{x:F3}");

            Console.WriteLine("\n=== Числа, не равные 0 ===");
            foreach (double x in nonZero)
                Console.WriteLine($"{x:F3}");

            Console.WriteLine("\n=== График ===");
            foreach (double x in nonZero)
            {
                int len = (int)Math.Min(Math.Abs(x) * 2, 40);
                string bar = x >= 0 ? new string('█', len) : new string(' ', 20) + new string('█', len);
                Console.WriteLine($"{x:F3} | {bar}");
            }

            Console.WriteLine($"\nРезультат сохранён в файл: OutPutFileTask5V10.txt");
            File.WriteAllText("OutPutFileTask5V10.txt", string.Join("\n", Array.ConvertAll(nonZero, d => d.ToString("F3"))));

            Console.ReadKey();
        }
    }
}