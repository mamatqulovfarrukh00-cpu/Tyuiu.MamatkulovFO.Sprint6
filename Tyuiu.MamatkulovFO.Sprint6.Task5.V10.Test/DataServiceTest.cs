

using Tyuiu.MamatkulovFO.Sprint6.Task5.V10.Lib;
using Tyuiu.MamatkulovFO.Sprint6.Task5.V10.Test;

namespace Tyuiu.mamatkulovFO.Sprint6.Task5.V10.Test
{
    [TestFixture]
    public class DataServiceTest
    {
        [Test]
        public void TestLoadFromDataFile()
        {
            // Arrange
            DataService ds = new DataService();
            string filePath = @"InPutDataFileTask5V10.txt"; // Fayl nomi aniq belgilangan

            // Act
            double[] actual = ds.LoadFromDataFile(filePath);

            // Assert — kutilgan natija
            double[] expected = new double[]
            {
                -13.0, -19.0, -9.82, 13.0, 11.49, -9.71, 3.36, 10.0, 14.52, 16.0,
                13.66, 0.48, 4.13, -0.11, 19.0, -17.36, 11.0, 11.28, -12.0, -12.35
            };

            // Massiv uzunliklarini tekshirish
            Assert.AreEqual(expected.Length, actual.Length, "Massivlar uzunliklari mos kelmaydi.");

            // Har bir elementni aniqlik bilan (0.001) solishtirish
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i], 0.001,
                    $"Index {i} da xato: kutilgan = {expected[i]}, olingan = {actual[i]}");
            }
        }
    }
}