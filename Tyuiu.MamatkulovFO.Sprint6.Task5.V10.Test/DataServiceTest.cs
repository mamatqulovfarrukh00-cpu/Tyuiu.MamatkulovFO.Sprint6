using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sprint6Task5.Tests;
using Tyuiu.MamatkulovFO.Sprint6.Task5.V10.Lib;

namespace Tyuiu.MamatkulovFO.Sprint6.Task5.V10.Tests
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidTest()
        {
            var ds = new DataService();
            var res = ds.LoadDataFromFile("InPutDataFileTask5V10.txt");

            // Kutilayotgan natija
            double[] expected = new double[]
            {
                -13.0, -19.0, -9.82, 13.0, 11.49, -9.71, 3.36, 10.0, 14.52, 16.0,
                13.66, 0.48, 4.13, -0.11, 19.0, -17.36, 11.0, 11.28, -12.0, -12.35
            };

            CollectionAssert.AreEqual(expected, (System.Collections.ICollection?)res);
        }
    }
}