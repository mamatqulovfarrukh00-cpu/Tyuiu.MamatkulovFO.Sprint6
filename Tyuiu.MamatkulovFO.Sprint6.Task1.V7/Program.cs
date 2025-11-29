using System;

using Tyuiu.MamatkulovFO.Sprint6.Task1.V7.Lib;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.MamatkulovFO.Sprint6.Task1.V7
{
    class Program
    {
        public static object DockStyle { get; private set; }

        [STAThread]
        static void Main()
        {
            var f = new Form();
            var t = new TextBox { Multiline = true, Dock = DockStyle};
            var b = new Button { Text = "Hisoblash", Dock = DockStyle };

            b.Click += (_, __) => t.Text = new DataService().GetMassFunction(-5, 5);

            
        }
    }
}