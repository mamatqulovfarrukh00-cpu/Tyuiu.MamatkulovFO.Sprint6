using System;
using Tyuiu.MamatkulovFO.Sprint6.Task5.V10.Lib;

namespace Tyuiu.MamatkulovFO.Sprint6.Task5.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("========================================================");

            string filePath = "InPutDataFileTask5V10.txt";

            var service = new DataService();

            try
            {
               
                double[] allNumbers = service.LoadFromDataFile(filePath);
                Console.WriteLine($"✅ Fayldan o'qildi: {allNumbers.Length} ta son");

                // 2. Nolga teng bo'lmaganlarni filtrlash
                double[] nonZeroNumbers = service.FilterNonZero(allNumbers);
                Console.WriteLine($"✅ Nolga teng emaslar: {nonZeroNumbers.Length} ta son");

                // 3. 3 xonagacha yaxlitlash
                double[] roundedNumbers = service.RoundToThreeDecimals(nonZeroNumbers);

                // 4. Chiqarish
                Console.WriteLine("\n):");
                foreach (var num in roundedNumbers)
                {
                    Console.WriteLine(num);
                }

                // 5. Grafik chizish
                service.PrintAsChart(roundedNumbers);

                Console.WriteLine("\n!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($": {ex.Message}");
            }

            Console.WriteLine("\n...");
            Console.ReadKey();
        }
    }
}