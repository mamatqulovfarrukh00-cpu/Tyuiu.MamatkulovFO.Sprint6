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
            var res = ds.GetMassFunction(-5, 5);
            Assert.AreEqual(11, res.Length);
            Assert.AreEqual(2.0, res[5], 0.01); 
        }
    }
}