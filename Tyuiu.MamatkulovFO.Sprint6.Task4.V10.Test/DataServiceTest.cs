using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MamatkulovFO.Sprint6.Task4.V10.Lib;

namespace Tyuiu.MamatkulovFO.Sprint6.Task4.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod_GetMassFunction()
        {
            var service = new DataService();
            var result = service.GetMassFunction(-5, 5);

            Assert.IsNotNull(result);
            
        }
    }
}