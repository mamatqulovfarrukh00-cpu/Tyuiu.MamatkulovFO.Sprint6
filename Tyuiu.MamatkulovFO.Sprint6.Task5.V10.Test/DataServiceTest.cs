using Tyuiu.MamatkulovFO.Sprint6.Task5.V10.Lib;
namespace Tyuiu.MamatkulovFO.Sprint6.Task5.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
<<<<<<< HEAD
        [Test]
        public void TestLoadFromDataFile()
        {
            var service = new DataService();
            var path = @"Sprint6Task5/InPutDataFileTask5V10.txt";

            var result = service.LoadFromDataFile(path);

            Assert.IsNotNull(result);
=======
        [TestMethod]
        public void LoadAndFilter_Returns20NonZeroValues()
        {
            var service = new DataService();
            var data = service.LoadFromDataFile("Sprint6Task/InPutDataFileTask5V10.txt");
            var result = service.FilterNonZero(data);

            Assert.AreEqual(20, result.Length);
>>>>>>> f16bf3c4bc39c750e2da926309ce802249295a52
        }
    }
}
