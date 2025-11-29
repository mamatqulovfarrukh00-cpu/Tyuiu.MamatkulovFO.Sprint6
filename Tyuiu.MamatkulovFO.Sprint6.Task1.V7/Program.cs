using System;
using Tyuiu.MamatkulovFO.Sprint6.Task1.V7.Lib;

namespace Tyuiu.MamatkulovF0.Sprint6.Task1.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService service = new DataService();
            double[] results = service.GetMassFunction(-5, 5);

       
            string output = "[";
            for (int i = 0; i < results.Length; i++)
            {
                output += results[i].ToString("F2");
                if (i < results.Length - 1)
                    output += ", ";
            }
            output += "]";

            Console.WriteLine(output);
            Console.ReadKey(); 
        }
    }
}