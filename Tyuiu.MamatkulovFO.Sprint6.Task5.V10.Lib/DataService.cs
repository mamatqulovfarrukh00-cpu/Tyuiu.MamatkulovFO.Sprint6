using System.Collections;
using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.MamatkulovFO.Sprint6.Task5.V10.Lib
{
    public class DataService : ISprint6Task5V10
    {
        private string? path;

        public ICollection? LoadDataFromFile(string v)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException("Файл не найден: " + path);

            var numbers = new List<double>();
            var lines = File.ReadAllLines(path);

            foreach (var line in lines)
            {
                string clean = line.Trim().Replace('.', ',');
                if (double.TryParse(clean, NumberStyles.Float, CultureInfo.InvariantCulture, out double num))
                {
                    if (num != 0)
                    {
                        numbers.Add(Math.Round(num, 3));
                    }
                }
            }

            return numbers;
        }

        public double[] LoadFromDataFile(string path)
        {
            throw new NotImplementedException();
        }
    }
}    

   

        
    

