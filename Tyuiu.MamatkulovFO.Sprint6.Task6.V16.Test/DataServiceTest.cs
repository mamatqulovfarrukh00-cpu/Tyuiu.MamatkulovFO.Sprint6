
using Tyuiu.MamatkulovFO.Sprint6.Task6.V16.Lib;

namespace Tyuiu.MamatkulovFO.Sprint6.Task6.V16.Test
{
    [TestFixture]
    public class DataServiceTest
    {
        [Test]
        public void TestCollectTextFromFile()
        {
            var service = new DataService();
            var path = @"Sprint6Task6/InPutDataFileTask6V16.txt";

            var result = service.CollectTextFromFile(path);
            Assert.IsTrue(result.Contains("b") || result.Contains("B"));
        }
    }
}