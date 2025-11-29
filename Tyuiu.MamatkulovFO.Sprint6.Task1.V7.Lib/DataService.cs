using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.MamatkulovFO.Sprint6.Task1.V7.Lib
{
    public class DataService : ISprint6Task1V7
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int size = stopValue - startValue + 1;
            double[] result = new double[size];

            for (int i = 0; i < size; i++)
            {
                int x = startValue + i;
                double denominator = Math.Cos(x) + x;

                if (Math.Abs(denominator) < 1e-10) 
                    result[i] = 0;
                else
                    result[i] = (2 * x - 3) / denominator + 5;
            }

            return result;
        }
    }
}
