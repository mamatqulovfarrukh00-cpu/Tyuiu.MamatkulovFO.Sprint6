using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.MamatkulovFO.Sprint6.Task4.V10.Lib
{
    public class DataService : ISprint6Task4V10
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            var results = new List<double>();
            for (int x = startValue; x <= stopValue; x++)
            {
                double result = CalculateF(x);
                results.Add(result);
            }
            return results.ToArray();
        }

        private double CalculateF(int x)
        {
            double denominator = Math.Sin(x) + 3;
            if (Math.Abs(denominator) < 1e-10) 
                return 0;

            double numerator = 5 * x + 2.5;
            double fraction = numerator / denominator;
            double cosTerm = Math.Cos(x);
            return fraction + 2 * x + cosTerm;
        }
    }
}

