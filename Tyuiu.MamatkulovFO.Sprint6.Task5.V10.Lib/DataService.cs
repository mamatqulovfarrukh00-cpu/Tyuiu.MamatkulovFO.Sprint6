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

            string content = File.ReadAllText(path);
            var result = new List<double>();

            // Barcha qatorlarni bitta qatorga birlashtiramiz (agar kerak bo'lsa)
            string[] numbers = content.Replace("\r", "").Split(new char[] { ',', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string raw in numbers)
            {
                string trimmed = raw.Trim();
                if (string.IsNullOrEmpty(trimmed)) continue;

                // Vergulni nuqtaga almashtiramiz (agar faylda 11,49 bo'lsa)
                string normalized = trimmed.Replace(',', '.');

                if (double.TryParse(normalized, out double value))
                {
                    if (value != 0.0)
                    {
                        result.Add(value); 
                    }
                }
            }

            return result.ToArray();
        }
    }
}
