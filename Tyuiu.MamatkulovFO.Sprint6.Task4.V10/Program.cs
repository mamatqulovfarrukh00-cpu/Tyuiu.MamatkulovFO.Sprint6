using System;
using System.IO;
using Tyuiu.MamatkulovFO.Sprint6.Task4.V10.Lib;

namespace Tyuiu.MamatkulovFO.Sprint6.Task4.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new DataService();
            double[] values = service.GetMassFunction(-5, 5);

            for (int i = 0; i < values.Length; i++)
            {
                double x = -5 + i;
                double y = values[i];
                string bar = "";

                if (y >= 0)
                {
                    int stars = (int)Math.Min(Math.Abs(y) * 2, 40);
                    bar = new string('█', stars);
                }
                else
                {
                    int stars = (int)Math.Min(Math.Abs(y) * 2, 40);
                    bar = new string(' ', 20) + new string('█', stars);
                }

                Console.WriteLine($"{x,3}: {bar} {y:F2}");
            }

            string filePath = "OutPutFileTask4V10.txt";
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("x\tF(x)");
                for (int i = 0; i < values.Length; i++)
                {
                    double x = -5 + i;
                    writer.WriteLine($"{x}\t{values[i]:F2}");
                }
            }

            Console.WriteLine($"\n{filePath}");
            Console.ReadKey();
        }
    }
}