using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.MamatkulovFO.Sprint6.Task6.V16.Lib
{
    public class DataService : ISprint6Task6V16
    {
        public string CollectTextFromFile(string path)
        {
            string text = File.ReadAllText(path);

          
            var wordsWithB = text.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                                 .Where(word => word.Contains('b') || word.Contains('B'))
                                 .ToArray();

            return string.Join(" ", wordsWithB);
        }

        public object GetWordsWithB(string fileName)
        {
            throw new NotImplementedException();
        }
    }
}
