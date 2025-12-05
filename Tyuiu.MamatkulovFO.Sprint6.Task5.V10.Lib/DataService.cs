using System;
using System.IO;
using System.Collections.Generic;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.MamatkulovFO.Sprint6.Task5.V10.Lib
{
    public class DataService : ISprint6Task5V10
    {
        public double[] LoadFromDataFile(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException("Файл не найден!", path);

            var lines = File.ReadAllLines(path);
            var result = new List<double>();

            foreach (var line in lines)
            {
                if (double.TryParse(line.Replace(',', '.'), out double number))
                {
                    if (number != 0) // Ненулевые числа
                        result.Add(Math.Round(number, 3)); // Округляем до 3 знаков
                }
            }

            return result.ToArray();
        }
    }
}

