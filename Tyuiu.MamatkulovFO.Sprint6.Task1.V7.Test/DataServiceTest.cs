using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MamatkulovFO.Sprint6.Task1.V7.Lib;

namespace Tyuiu.MamatkulovFO.Sprint6.Task1.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunctionTest()
        {
            var service = new DataService();
            double[] values = service.GetMassFunction(-5, 5);

            Assert.IsNotNull(values);
            Assert.AreEqual(11, values.Length);

           
            Assert.AreEqual(2.0, values[5], 0.01); 
        }
    }
}