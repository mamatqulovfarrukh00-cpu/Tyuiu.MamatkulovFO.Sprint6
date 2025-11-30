using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MamatkulovFO.Sprint6.Task5.V10.Lib;

namespace Tyuiu.MamatkulovFO.Sprint6.Task5.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestLoadAndFilter()
        {
            var service = new DataService();
            double[] data = service.LoadFromDataFile("Sprint6Task5/InPutDataFileTask5V10.txt");
            double[] result = service.FilterNonZero(data);
            Assert.AreEqual(20, result.Length);
        }
    }
}