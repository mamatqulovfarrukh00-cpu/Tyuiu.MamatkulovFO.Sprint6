
using Tyuiu.MamatkulovFO.Sprint6.Task5.V10.Lib;

namespace Tyuiu.MamatkulovFO.Sprint6.Task5.V10.Test
{
    [TestFixture]
    public class DataServiceTest
    {
        [Test]
        public void TestLoadFromDataFile()
        {
            var service = new DataService();
            var path = @"Sprint6Task5/InPutDataFileTask5V10.txt";

            var result = service.LoadFromDataFile(path);

            
            Assert.IsTrue(result.Length > 0);
            Assert.IsFalse(Array.Exists(result, x => x == 0));
        }
    }
}
