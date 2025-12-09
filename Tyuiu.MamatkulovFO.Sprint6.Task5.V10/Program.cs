using System;
using System.Linq;
using Tyuiu.MamatkulovFO.Sprint6.Task5.V10.Lib;

namespace Tyuiu.MamatkulovFO.Sprint6.Task5.V10
{
    internal static class Program
    {
        private static bool result;

        static void Main(string[] args)
        {
            var service = new DataService();
            try
            {
                var data = service.LoadDataFromFile("InPutDataFileTask5V10.txt");

                // Выводим массив в виде: [-13.0, -19.0, -9.82, ...]
              
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }

            Console.ReadKey(); // Ожидание нажатия клавиши
        }
    }
}