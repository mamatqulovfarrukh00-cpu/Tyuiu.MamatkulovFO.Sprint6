
using Tyuiu.MamatkulovFO.Sprint6.Task5.V10.Lib;
using System.IO;

namespace Tyuiu.MamatkulovFO.Sprint6.Task5.V10.Test
{
    [TestFixture]
    public class DataServiceTest
    {
        private DataService service;

        [SetUp]
        public void Setup()
        {
            service = new DataService();
        }

        [Test]
        public void Test_LoadFromDataFile_ShouldReturnCorrectArray()
        {
            string testFilePath = "TestData.txt";
            File.WriteAllLines(testFilePath, new string[]
            {
                "-13",
                "-19",
                "-9,82",
                "13",
                "11,49",
                "-9,71",
                "3,36",
                "10",
                "14,52",
                "16",
                "13,66",
                "0,48",
                "4,13",
                "-0,11",
                "19",
                "-17,36",
                "11",
                "11,28",
                "-12",
                "-12,35"
            });

            double[] result = service.LoadFromDataFile(testFilePath);
            Assert.AreEqual(20, result.Length);
            Assert.AreEqual(-13.0, result[0]);
            Assert.AreEqual(-9.82, result[2]); 
            Assert.AreEqual(-0.11, result[13]);

            File.Delete(testFilePath);
        }

        [Test]
        public void Test_FilterNonZero_ShouldExcludeZeros()
        {
            double[] input = { 1.0, 0.0, -2.5, 0.0, 3.14 };
            double[] result = service.FilterNonZero(input);
            Assert.AreEqual(3, result.Length);
            Assert.IsTrue(result.All(x => x != 0));
        }

        [Test]
        public void Test_RoundToThreeDecimals_ShouldRoundCorrectly()
        {
            double[] input = { 1.23456, -9.87654, 0.1 };
            double[] result = service.RoundToThreeDecimals(input);
            Assert.AreEqual(1.235, result[0]);
            Assert.AreEqual(-9.877, result[1]);
            Assert.AreEqual(0.100, result[2]);
        }
    }
}