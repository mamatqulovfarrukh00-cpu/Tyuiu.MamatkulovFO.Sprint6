using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MamatkulovFO.Sprint6.Task0.V21.Lib;

namespace Tyuiu.MamatkulovFO.Sprint6.Task0.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            var service = new DataService();
            double result = service.Calculate(2);

           
            Assert.AreEqual(13.0, result, 0.001); 
        }
    }
}