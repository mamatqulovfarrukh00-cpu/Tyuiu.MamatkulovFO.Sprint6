using System;
using Tyuiu.MamatkulovFO.Sprint6.Task5.V10.Lib;

namespace Tyuiu.MamatkulovFO.Sprint6.Task5.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("📌 Sprint6 Task5 V10 - Ma'lumotlarni o'qish va grafik chizish");
            Console.WriteLine("========================================================");

            string filePath = "InPutDataFileTask5V10.txt";

            var service = new DataService();

            try
            {
                // 1. Fayldan o'qish
                double[] allNumbers = service.LoadFromDataFile(filePath);
                Console.WriteLine($"✅ Fayldan o'qildi: {allNumbers.Length} ta son");

                // 2. Nolga teng bo'lmaganlarni filtrlash
                double[] nonZeroNumbers = service.FilterNonZero(allNumbers);
                Console.WriteLine($"✅ Nolga teng emaslar: {nonZeroNumbers.Length} ta son");

                // 3. 👇 YAXLITLASHNI OLIB TASHLADIK — TESTGA MOSLIK UCHUN

                // 4. Chiqarish (asli formatda, yaxlitlanmagan)
                Console.WriteLine("\n🔢 Nolga teng bo'lmagan sonlar (asli formatda):");
                foreach (var num in nonZeroNumbers)
                {
                    Console.WriteLine(num);
                }

                // 5. Grafik chizish (bu yerda ham yaxlitlash yo'q, lekin konsolda ko'rinish uchun F3 ishlatiladi)
                service.PrintAsChart(nonZeroNumbers);

                Console.WriteLine("\n🎉 Vazifa muvaffaqiyatli bajarildi!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Xato: {ex.Message}");
            }

            Console.WriteLine("\nQoldirish uchun istalgan tugmani bosing...");
            Console.ReadKey();
        }
    }
}