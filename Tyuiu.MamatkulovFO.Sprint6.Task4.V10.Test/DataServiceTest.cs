using System;
using Tyuiu.MamatkulovFO.Sprint6.Task4.V10.Lib;
namespace Tyuiu.MamatkulovFO.Sprint6.Task4.V10.Test;

public class DataServiceTest
{
    public static void Run()
    {
        var service = new DataService();
        double[] values = service.GetMassFunction(-5, 5);

        Console.WriteLine("x\tF(x)");
        for (int i = 0; i < values.Length; i++)
        {
            int x = -5 + i;
            Console.WriteLine($"{x}\t{values[i]:F2}");
        }
    }
}