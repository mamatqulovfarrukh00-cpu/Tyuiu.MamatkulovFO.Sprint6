
using Tyuiu.MamatkulovFO.Sprint6.Task7.V3.Lib;

namespace Tyuiu.MamatkulovFO.Sprint6.Task7.V3.Test
{
    [TestFixture]
    public class DataServiceTest
    {
        [Test]
        public void TestGetMatrix()
        {
            var service = new DataService();
            var path = @"Sprint6Task7/InPutDataFileTask7V3.csv";

            var result = service.GetMatrix(path);

            // Проверяем, что матрица не null
            Assert.IsNotNull(result);

           

            
            
        }
    }
}