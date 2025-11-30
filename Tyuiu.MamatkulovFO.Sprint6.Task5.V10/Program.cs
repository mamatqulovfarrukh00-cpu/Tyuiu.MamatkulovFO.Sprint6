using System;
using System.IO;
using Tyuiu.MamatkulovFO.Sprint6.Task5.V10.Lib;

namespace Tyuiu.MamatkulovFO.Sprint6.Task5.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new DataService();
            double[] all = service.LoadFromDataFile("Sprint6Task5/InPutDataFileTask5V10.txt");
            double[] nonZero = service.FilterNonZero(all);

            Console.WriteLine("=== Все числа ===");
            foreach (double x in all)
                Console.WriteLine($"{x:F3}");

            Console.WriteLine("\n=== Не равные 0 ===");
            foreach (double x in nonZero)
                Console.WriteLine($"{x:F3}");

            Console.WriteLine("\n=== Диаграмма ===");
            foreach (double x in nonZero)
            {
                int len = (int)Math.Min(Math.Abs(x) * 2, 40);
                string bar = x >= 0 ? new string('█', len) : new string(' ', 20) + new string('█', len);
                Console.WriteLine($"{x:F3} | {bar}");
            }

            File.WriteAllLines("OutPutFileTask5V10.txt", Array.ConvertAll(nonZero, d => d.ToString("F3")));
            Console.ReadKey();
        }
    }
}