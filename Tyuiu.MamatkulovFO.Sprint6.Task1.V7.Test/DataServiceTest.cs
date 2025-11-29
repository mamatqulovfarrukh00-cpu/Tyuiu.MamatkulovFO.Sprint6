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
            var ds = new DataService();
            string result = ds.GetMassFunction(-5, 5);

          
            string expected = "[7.76, 7.36, 7.26, 7.9, 15.88, 2.0, 0.43, 5.63, 6.49, 6.49, 6.32]";

            Assert.AreEqual(expected, result);
        }
    }
}