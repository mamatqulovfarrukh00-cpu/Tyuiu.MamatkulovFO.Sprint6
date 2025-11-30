using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.MamatkulovFO.Sprint6.Task5.V10.Lib
{
    public class DataService : ISprint6Task5V10
    {
        public double[] LoadFromDataFile(string path)
        {
            string[] lines = File.ReadAllLines(path);
            var list = new System.Collections.Generic.List<double>();
            foreach (string line in lines)
            {
                if (!string.IsNullOrWhiteSpace(line))
                {
                    string clean = line.Trim().Replace(',', '.');
                    if (double.TryParse(clean, out double v))
                        list.Add(v);
                }
            }
            return list.ToArray();
        }

        public double[] FilterNonZero(double[] data)
        {
            var filtered = new System.Collections.Generic.List<double>();
            foreach (double d in data)
                if (Math.Abs(d) > 1e-10)
                    filtered.Add(d);
            return filtered.ToArray();
        }
    }
}
