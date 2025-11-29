using System;
using System.Text;

namespace Tyuiu.MamatkulovFO.Sprint6.Task1.V7.Lib
{
    public class DataService
    {
        public string GetMassFunction(int startValue, int stopValue)
        {
            var sb = new StringBuilder("[");
            for (int i = startValue; i <= stopValue; i++)
            {
                double denom = Math.Cos(i) + i;
                double value = Math.Abs(denom) < 1e-10 ? 0 : (2.0 * i - 3.0) / denom + 5.0;

                if (i > startValue) sb.Append(", ");

                string formatted = value.ToString("F2");
                if (formatted.EndsWith(".00"))
                    formatted = formatted.Substring(0, formatted.Length - 2) + "0";

                sb.Append(formatted);
            }
            sb.Append("]");
            return sb.ToString();
        }
    }
}