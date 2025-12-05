using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.MamatkulovFO.Sprint6.Task6.V16.Lib;

public class DataService : ISprint6Task6V16
{
    
    
        public string CollectTextFromFile(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException("Файл не найден!", path);

            var text = File.ReadAllText(path);
            var lines = text.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            // Faqat birinchi satrni olib, uning ichidagi "b" harfi bor so'zlarini ajratamiz
            var firstLine = lines[0]; // Birinchi satr
            var words = firstLine.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            var resultWords = words.Where(word => word.Contains('b') || word.Contains('B')).ToArray();

            return string.Join(" ", resultWords);
        }
}
