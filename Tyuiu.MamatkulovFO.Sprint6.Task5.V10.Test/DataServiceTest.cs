using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MamatkulovFO.Sprint6.Task5.V10.Lib;

namespace Tyuiu.MamatkulovFO.Sprint6.Task5.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void LoadAndFilter_Returns20NonZeroValues()
        {
            var service = new DataService();
            var data = service.LoadFromDataFile("Sprint6Task/InPutDataFileTask5V10.txt");
            var result = service.FilterNonZero(data);

            Assert.AreEqual(20, result.Length);
        }
    }
}