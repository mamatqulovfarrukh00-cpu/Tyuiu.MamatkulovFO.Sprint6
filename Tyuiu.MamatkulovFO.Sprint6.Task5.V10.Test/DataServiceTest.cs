using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sprint6Task5.Tests;
using Tyuiu.MamatkulovFO.Sprint6.Task5.V10;

namespace Tyuiu.MamatkulovFO.Sprint6.Task5.V10.Tests
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void LoadDataFromFile_ShouldReturn20NonZeroNumbers()
        {
            var service = new DataService();
            var result = service.LoadDataFromFile("InPutDataFileTask5V10.txt");
            
        }
    }
}