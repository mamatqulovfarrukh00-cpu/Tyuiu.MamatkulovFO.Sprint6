using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.MamatkulovFO.Sprint6.Task5.V10.Lib
{
    public class DataService : ISprint6Task5V10
    {

    
        
        

            public double[] LoadFromDataFile(string path)
            {
                if (!File.Exists(path))
                    throw new FileNotFoundException("Fayl topilmadi.", path);

                var lines = File.ReadAllLines(path);
                var numbers = new List<double>();

                foreach (var line in lines)
                {
                    string cleanedLine = line.Trim().Replace(',', '.'); 
                    if (double.TryParse(cleanedLine, out double number))
                    {
                        numbers.Add(number);
                    }
                }

                return numbers.ToArray();
            }

            public double[] FilterNonZero(double[] data)
            {
                return data.Where(x => x != 0).ToArray();
            }

          

            public void PrintAsChart(double[] data)
            {
                Console.WriteLine("\n📊 Grafik (simvolli chiziq):");
                foreach (var num in data)
                {
                    int barLength = (int)Math.Abs(num);
                    if (barLength > 50) barLength = 50;

                    string sign = num >= 0 ? "+" : "-";
                    string bar = new string('#', barLength);
                    Console.WriteLine($"{sign} {num:F3} |{bar}");
                }
            }
        
    }
}

