using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sprint6Task5;

namespace Sprint6Task5.Tests
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void LoadDataFromFile_ReturnsCorrectCount()
        {
            var service = new DataService();
            var data = service.LoadDataFromFile("InPutDataFileTask5V10.txt");
           
        }
    }
}