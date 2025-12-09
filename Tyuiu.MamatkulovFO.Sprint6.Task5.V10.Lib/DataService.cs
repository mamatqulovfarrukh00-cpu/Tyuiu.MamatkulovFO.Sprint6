using System.Collections;
using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.MamatkulovFO.Sprint6.Task5.V10.Lib
{
    public class DataService : ISprint6Task5V10
    {
        public ICollection? LoadDataFromFile(string v)
        {
            throw new NotImplementedException();
        }

        public double[] LoadFromDataFile(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException("Fayl topilmadi: " + path);

            var numbers = new List<double>();
            var lines = File.ReadAllLines(path);

            foreach (var line in lines)
            {
                var clean = line.Trim().Replace('.', ','); 
                if (double.TryParse(clean, NumberStyles.Float, CultureInfo.InvariantCulture, out double num))
                {
                    if (num != 0)
                    {
                      
                        double rounded = Math.Round(num, 3);
                        numbers.Add(rounded);
                    }
                }
            }

            return numbers.ToArray();
        }
    }
}
        
    

