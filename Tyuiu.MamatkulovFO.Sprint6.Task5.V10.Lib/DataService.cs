using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.MamatkulovFO.Sprint6.Task5.V10.Lib
{
    public class DataService : ISprint6Task5V10
    {
        public double[] LoadFromDataFile(string path)
        {
            // Fayldan barcha qatorlarni o'qish
            string[] lines = File.ReadAllLines(path);

            // Nolga teng bo'lmagan sonlarni saqlash uchun list
            var numbers = new System.Collections.Generic.List<double>();

            foreach (string line in lines)
            {
                // Har bir qatorni double ga aylantirishga harakat qilish
                if (double.TryParse(line, out double value))
                {
                    // Agar qiymat nolga teng bo'lmasa, ro'yxatga qo'shish
                    if (value != 0)
                    {
                        numbers.Add(value);
                    }
                }
            }

            // Natijani massiv sifatida qaytarish
            return numbers.ToArray();
        }
    }
}

