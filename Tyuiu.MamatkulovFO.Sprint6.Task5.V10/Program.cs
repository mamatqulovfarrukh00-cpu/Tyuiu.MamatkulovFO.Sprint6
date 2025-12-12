using System;

using Tyuiu.MamatkulovFO.Sprint6.Task5.V10.Lib;

namespace Tyuiu.mamatkulovFO.Sprint6.Task5.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт 6 | Задание 5 | Вариант 10 | Маматкулов Ф.О.";
            Console.WriteLine("==========================================================================");
            Console.WriteLine("* Спринт #6                                                              *");
            Console.WriteLine("* Тема: Работа с файлами и массивами                                     *");
            Console.WriteLine("* Задание #5                                                             *");
            Console.WriteLine("* Вариант #10                                                            *");
            Console.WriteLine("* Выполнил: Маматкулов Фаррух Охунжонович                                *");
            Console.WriteLine("==========================================================================");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу, которая считывает данные из текстового файла        *");
            Console.WriteLine("* и возвращает массив чисел, не равных нулю.                             *");
            Console.WriteLine("==========================================================================");

            // Fayl nomi (fayl dastur ishlayotgan papkada bo'lishi kerak)
            string filePath = @"InPutDataFileTask5V10.txt";
            DataService ds = new DataService();

            try
            {
                double[] result = ds.LoadFromDataFile(filePath);

                Console.WriteLine("\nМАССИВ ЧИСЕЛ, НЕ РАВНЫХ НУЛЮ:");
                for (int i = 0; i < result.Length; i++)
                {
                    // Sonlarni 2 xonali kasr bilan chiqarish (masalan: -9.82)
                    Console.WriteLine($"{result[i]:F2}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nОШИБКА: Не удалось прочитать файл '{filePath}'.");
                Console.WriteLine($"Причина: {ex.Message}");
            }

            Console.WriteLine("\n==========================================================================");
            Console.WriteLine("Для выхода нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}