using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.MamatkulovFO.Sprint6.Task1.V7.Lib
{
    public class DataService : ISprint6Task1V7
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
          
            int count = stopValue - startValue + 1;
            double[] results = new double[count];
            int index = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = Math.Cos(x) + x;

              
                if (Math.Abs(denominator) < 1e-10)
                {
                    results[index] = 0.0;
                }
                else
                {
                    double numerator = 2 * x - 3;
                    double result = numerator / denominator + 5;
                    results[index] = Math.Round(result, 2); 
                }

                index++;
            }

            return results;
        }
    }
}
    


