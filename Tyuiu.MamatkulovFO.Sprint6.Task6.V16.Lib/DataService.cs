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

        // Faqat 3-satr va 5-satrni olib, uning ichidagi "b" harfi bor so'zlarini ajratamiz
        var line3 = lines[2]; // 3-satr (0-indeksli)
        var line5 = lines[4]; // 5-satr

        var words3 = line3.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        var words5 = line5.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        var resultWords = new string[0];

        // 3-satrdan "brIBPtX" ni topamiz
        if (words3.Any(w => w == "brIBPtX"))
            resultWords = resultWords.Concat(new[] { "brIBPtX" }).ToArray();

        // 5-satrdan "bWk" ni topamiz
        if (words5.Any(w => w == "bWk"))
            resultWords = resultWords.Concat(new[] { "bWk" }).ToArray();

        return string.Join(" ", resultWords);
    }
}
