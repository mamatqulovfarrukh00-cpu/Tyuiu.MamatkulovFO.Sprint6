using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.MamatkulovFO.Sprint6.Task1.V7.Lib
{
    public class DataService : ISprint6Task1V7
    {
        public string GetMassFunction(int startValue, int stopValue)
        {
            var sb = new StringBuilder("[");
            for (int i = startValue; i <= stopValue; i++)
            {
                double denom = Math.Cos(i) + i;
                double value;

                if (Math.Abs(denom) < 1e-10)
                    value = 0;
                else
                    value = (2.0 * i - 3.0) / denom + 5.0; // TO'G'RI FORMULA

                // Format: 7.9, 2.0, 4.35 kabi
                string formatted = value.ToString("0.00").TrimEnd('0').TrimEnd('.');
                if (!formatted.Contains(".")) formatted += ".0";

                if (i > startValue) sb.Append(", ");
                sb.Append(formatted);
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
