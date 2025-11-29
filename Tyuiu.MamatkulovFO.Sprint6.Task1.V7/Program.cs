using System;

using Tyuiu.MamatkulovFO.Sprint6.Task1.V7.Lib;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.MamatkulovFO.Sprint6.Task1.V7
{
    static class Program
    {
        private static object DockStyle;

        [STAThread]
        static void Main()
        {
           

            var form = new Form { Text = "V7", Width = 400, Height = 300 };
            var textBox = new TextBox
            {
               
            };

            var button = new Button { Text = "Hisoblash", Dock = DockStyle };

            button.Click += (_, __) =>
            {
                var ds = new DataService();
                double[] results = ds.GetMassFunction(-5, 5);

                // Natijani massiv sifatida formatlab chiqaramiz: [7,76, 7,36, ...]
                string output = "[";
                for (int i = 0; i < results.Length; i++)
                {
                    double val = results[i];
                    string formatted = val.ToString("F2").TrimEnd('0').TrimEnd(',');
                    if (i > 0) output += ", ";
                    output += formatted;
                }
                output += "]";

                textBox.Text = output;
            };

        }
    }
}