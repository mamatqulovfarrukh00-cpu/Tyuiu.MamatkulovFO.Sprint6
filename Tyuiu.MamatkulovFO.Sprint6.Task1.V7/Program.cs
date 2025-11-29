using System;

using Tyuiu.MamatkulovFO.Sprint6.Task1.V7.Lib;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.MamatkulovFO.Sprint6.Task1.V7
{
    class P
    {
        public static object DockStyle { get; private set; }

        [STAThread]
        static void Main()
        {
            var f = new Form();
            var t = new TextBox { Multiline = true, Dock = DockStyle };
            var b = new Button { Text = "Hisoblash", Dock = DockStyle };

            b.Click += (_, __) =>
            {
                var r = new DataService().GetMassFunction(-5, 5);
                for (int i = -5; i <= 5; i++)
                {
                    double val = r[i + 5];
                    string formatted = val.ToString("F2").TrimEnd('0').TrimEnd(',');
                    t.AppendText($"F({i}) = {formatted}\n");
                }
            };

           
        }
    }
}