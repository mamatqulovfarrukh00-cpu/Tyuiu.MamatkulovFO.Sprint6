using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MamatkulovFO.Sprint6.Task5.V10.Lib;

namespace Tyuiu.MamatkulovFO.Sprint6.Task5.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod_LoadAndFilter()
        {
            var service = new DataService();
            double[] data = service.LoadFromDataFile("InPutDataFileTask5V10.txt");
            Assert.IsNotNull(data);
            Assert.IsTrue(data.Length > 0);

            double[] filtered = service.FilterNonZero(data);
            Assert.IsTrue(filtered.Length > 0);
        }
    }
}