using Tyuiu.MamatkulovFO.Sprint6.Task6.V16.Lib;

namespace Tyuiu.MamatkulovFO.Sprint6.Task6.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var service = new DataService();

            // ✅ To'liq yo'l — shuni o'zgartiring!
            string filePath = @"C:\Users\Фарух\source\repos\Tyuiu.MamatkulovFO.Sprint6.Task6.V16\Sprint6Task6\InPutDataFileTask6V16.txt";

            try
            {
                string result = service.CollectTextFromFile(filePath);

                Console.WriteLine("Слова с буквой 'b':");
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            Console.ReadKey();
        }
    }
}