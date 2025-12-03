
using Tyuiu.MamatkulovFO.Sprint6.Task6.V16.Lib;

namespace Tyuiu.MamatkulovFO.Sprint6.Task6.V16.Test
{
    /// <summary>
    /// Тестовый класс для проверки метода CollectTextFromFile
    /// </summary>
    [TestFixture]
    public class DataServiceTest
    {
        [Test]
        public void TestCollectTextFromFile()
        {
            // Укажите актуальный путь к вашему тестовому файлу
            string testFilePath = @"Sprint6Task6\InPutDataFileTask6V16.txt";

            var service = new DataService();
            string result = service.CollectTextFromFile(testFilePath);

            // Ожидаемый результат (все слова с 'b' или 'B')
            string expected = "UPPfdzU ulzPXa UpGwjzkBH xvfsWpk BYiySs S OHcr NsMnNzS Y KgepHrKCHa BXGdYDF brIBPtX vatYxkk gLertvwzs KyiidnDo FVUh XNQBU sMLuPzlvneiTo XIpph QN hZznJL bWk Rz tfouGdncXlJ";

            Assert.AreEqual(expected, result);
        }
    }
}