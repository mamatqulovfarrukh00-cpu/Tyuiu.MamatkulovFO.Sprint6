using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.MamatkulovFO.Sprint6.Task4.V10.Lib
{
    public class Dataservice : ISprint6Task4V10
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int length = stopValue - startValue + 1;
            double[] result = new double[length];

            for (int i = 0; i < length; i++)
            {
                double x = startValue + i;
                double denominator = Math.Sin(x) + 3;

                if (Math.Abs(denominator) < 1e-10)
                {
                    result[i] = 0;
                }
                else
                {
                    result[i] = (5 * x + 2.5) / denominator + 2 * x + Math.Cos(x);
                }

                result[i] = Math.Round(result[i], 2);
            }

            return result;
        }
    }
}
