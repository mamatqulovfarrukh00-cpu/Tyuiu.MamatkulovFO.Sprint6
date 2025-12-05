using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.MamatkulovFO.Sprint6.Task6.V16.Lib;

public class DataService : ISprint6Task6V16
{
    public string CollectTextFromFile(string path)
    {
        if (!File.Exists(path))
            throw new FileNotFoundException("Файл не найден!", path);

        var text = File.ReadAllText(path);
        var words = text.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);

       
        var resultWords = words.Where(word => word.Contains('b') || word.Contains('B')).ToArray();

        return string.Join(" ", resultWords);
    }
}
