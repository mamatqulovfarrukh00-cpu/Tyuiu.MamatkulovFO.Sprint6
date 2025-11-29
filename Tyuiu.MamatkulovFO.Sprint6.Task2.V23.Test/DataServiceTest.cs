using Tyuiu.MamatkulovFO.Sprint6.Task2.V23.Lib;
namespace Tyuiu.MamatkulovFO.Sprint6.Task2.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestFromMinus5To5()
        {
            DataService ds = new DataService();
            double[] r = ds.GetMassFunction(-5, 5);

            
            Assert.AreEqual(11, r.Length);

            
            Assert.AreEqual(0.0, r[6]); 
        }
    }
}
