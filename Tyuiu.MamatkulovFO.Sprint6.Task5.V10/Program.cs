using System;
using Tyuiu.MamatkulovFO.Sprint6.Task5.V10.Lib;

namespace Tyuiu.MamatkulovFO.Sprint6.Task5.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new DataService();
            double[] allData = service.LoadFromDataFile("InPutDataFileTask5V10.txt");
            double[] nonZero = service.FilterNonZero(allData);

            Console.WriteLine("=== Все числа из файла ===");
            foreach (double d in allData)
            {
                Console.WriteLine($"{d:F3}");
            }

            Console.WriteLine("\n=== Числа, не равные 0 ===");
            foreach (double d in nonZero)
            {
                Console.WriteLine($"{d:F3}");
            }

            Console.WriteLine("\n=== Диаграмма (ASCII) ===");
            foreach (double d in nonZero)
            {
                int barLength = (int)Math.Abs(d) * 2;
                if (barLength > 40) barLength = 40;
                string bar = d >= 0 ? new string('█', barLength) : new string(' ', 20) + new string('█', barLength);
                Console.WriteLine($"{d:F3} | {bar}");
            }

            Console.WriteLine("\nНажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}