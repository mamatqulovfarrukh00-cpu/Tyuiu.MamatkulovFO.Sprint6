using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.MamatkulovFO.Sprint6.Task3.V10.Lib
{
    public class DataService : ISprint6Task3V10
    {
        public int[,] Calculate(int[,] matrix)
        {
           
            for (int j = 0; j < 5; j++)
            {
                if (matrix[4, j] % 2 == 0) 
                {
                    matrix[4, j] = 0;
                }
            }
            return matrix;
        }
    }
}
