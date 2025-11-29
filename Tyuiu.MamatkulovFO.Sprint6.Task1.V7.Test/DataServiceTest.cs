using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MamatkulovFO.Sprint6.Task1.V7.Lib;

namespace Tyuiu.MamatkulovF0.Sprint6.Task1.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        private DataService _service;

        [TestInitialize]
        public void Setup()
        {
            _service = new DataService();
        }

        [TestMethod]
        public void GetMassFunction_ShouldReturnCorrectArray_ForRangeMinus5To5()
        {
            double[] result = _service.GetMassFunction(-5, 5);

            Assert.AreEqual(11, result.Length);

            
            double[] expected = { 7.76, 7.36, 7.26, 7.90, 15.88, 2.00, 4.35, 5.63, 6.49, 6.49, 6.32 };

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i], 0.01, $"Index {i} ошибок");
            }
        }

        [TestMethod]
        public void GetMassFunction_ShouldHandleDivisionByZero()
        {
           
            double[] result = _service.GetMassFunction(0, 0);
            Assert.AreEqual(2.0, result[0], 0.01); // F(0) = (0-3)/(1+0)+5 = 2.0
        }
    }
}