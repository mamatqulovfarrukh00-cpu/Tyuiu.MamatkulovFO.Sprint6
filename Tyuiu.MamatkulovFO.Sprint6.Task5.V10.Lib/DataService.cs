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

            foreach (string line in lines)
            {
                // Har bir qatorni vergul bilan ajratamiz
                string[] parts = line.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string part in parts)
                {
                    string cleaned = part.Trim().Replace(',', '.'); // Vergulni nuqtaga almashtirish

                    if (double.TryParse(cleaned, out double number))
                    {
                        if (number != 0.0) // Nolga teng bo'lmaganlarni ajratamiz
                        {
                            result.Add(number); // ❗️ YAXLITLAMAYMIZ!
                        }
                    }
                }
            }

            return result.ToArray();
        }
    }
}