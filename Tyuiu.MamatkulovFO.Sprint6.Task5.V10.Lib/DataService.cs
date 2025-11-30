using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.MamatkulovFO.Sprint6.Task5.V10.Lib
{
    public class DataService : ISprint6Task5V10
    {
        public double[] LoadFromDataFile(string path)
        {
            
            

            foreach (string line in lines)
            {
                if (!string.IsNullOrWhiteSpace(line))
                {
                    string cleanLine = line.Trim().Replace(',', '.');
                    if (double.TryParse(cleanLine, out double value))
                    {
                        list.Add(value);
                    }
                }
            }

            return list.ToArray();
        }

        public double[] FilterNonZero(double[] data)
        {
            var filtered = new System.Collections.Generic.List<double>();
            foreach (double d in data)
            {
                if (Math.Abs(d) > 1e-10)
                {
                    filtered.Add(d);
                }
            }
            return filtered.ToArray();
        }
    }
}
    

    

