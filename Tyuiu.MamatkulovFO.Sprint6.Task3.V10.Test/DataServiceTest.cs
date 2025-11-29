
using Tyuiu.MamatkulovFO.Sprint6.Task3.V10.Lib;

namespace Tyuiu.MamatkulovFO.Sprint6.Task3.V10.Test
{
    [TestFixture]
    public class DataServiceTest
    {
        [Test]
        public void TestCalculate()
        {
            var ds = new DataService();

            int[,] input = {
                {-17, 6, -19, 6, -13},
                {-19, 3, 12, -11, 19},
                {-20, 11, 9, 19, -19},
                {-20, 10, -9, 17, 9},
                {-4, 9, -8, 13, -8}  
            };

            int[,] expected = {
                {-17, 6, -19, 6, -13},
                {-19, 3, 12, -11, 19},
                {-20, 11, 9, 19, -19},
                {-20, 10, -9, 17, 9},
                {0, 9, 0, 13, 0}  
            };

            int[,] result = ds.Calculate(input);

         
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Assert.AreEqual(expected[i, j], result[i, j]);
                }
            }
        }
    }
}