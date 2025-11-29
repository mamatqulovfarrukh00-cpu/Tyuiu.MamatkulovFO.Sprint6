using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.MamatkulovFO.Sprint6.Task2.V23.Lib
{
    public class DataService : ISprint6Task2V23
    {
        public double[] GetMassFunction(int start, int stop)
        {
            double[] res = new double[stop - start + 1];
            int i = 0;

            for (int x = start; x <= stop; x++)
            {
                double den = 2 * x - 2; 

                if (Math.Abs(den) < 0.0001)
                {
                    res[i] = 0.0;
                }
                else
                {
                    double value = 4 - 2 * x + (2 + Math.Cos(x)) / den;
                    res[i] = Math.Round(value, 2); 
                }
                i++;
            }

            return res;
        }
    }
}
