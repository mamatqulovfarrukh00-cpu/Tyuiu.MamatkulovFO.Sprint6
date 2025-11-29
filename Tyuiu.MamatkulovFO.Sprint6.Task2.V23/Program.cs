using System;
using System.Drawing;

using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.MamatkulovF0.Sprint6.Task2.V23
{
    using System;

    class Program
    {
        static void Main()
        {
            for (int x = -5; x <= 5; x++)
            {
                double fx = CalcF(x);
                Console.WriteLine($"F({x}) = {fx:F2}");
            }
        }

        static double CalcF(int x)
        {
            double den = 2 * x - 2;
            if (Math.Abs(den) < 1e-9) return 0.0;
            return 4 - 2 * x + (2 + Math.Cos(x)) / den;
        }
    }
}