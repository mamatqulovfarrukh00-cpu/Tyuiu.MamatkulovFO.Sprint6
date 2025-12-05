using Tyuiu.MamatkulovFO.Sprint6.Task5.V10.Lib;
namespace Tyuiu.MamatkulovFO.Sprint6.Task5.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [Test]
        public void TestLoadFromDataFile()
        {
            var service = new DataService();
            var path = @"Sprint6Task5/InPutDataFileTask5V10.txt";

            var result = service.LoadFromDataFile(path);

            Assert.IsNotNull(result);
        }
    }
}
