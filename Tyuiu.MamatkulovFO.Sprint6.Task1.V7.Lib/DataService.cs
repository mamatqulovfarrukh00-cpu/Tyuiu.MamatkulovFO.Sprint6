using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.MamatkulovFO.Sprint6.Task1.V7.Lib
{
    public class DataService : ISprint6Task1V7
    {
        public string GetMassFunction(int startValue, int stopValue)
        {
            var sb = new StringBuilder();
            sb.Append("[");

            for (int i = startValue; i <= stopValue; i++)
            {
                double denom = Math.Cos(i) + i;
                double value = Math.Abs(denom) < 1e-10 ? 0 : (2 * i - 3) / denom + 5;

                if (i > startValue) sb.Append(", ");
                sb.Append(value.ToString("0.##")); // <-- Bu yerda tuzatildi!
            }

            sb.Append("]");
            return sb.ToString();
        }

        double[] ISprint6Task1V7.GetMassFunction(int startValue, int stopValue)
        {
            throw new NotImplementedException();
        }
    }
}
