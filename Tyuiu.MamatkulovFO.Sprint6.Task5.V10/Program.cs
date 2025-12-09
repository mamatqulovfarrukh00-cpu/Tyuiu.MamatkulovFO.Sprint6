using System;
using System.Windows.Forms;
using Tyuiu.MamatkulovFO.Sprint6.Task5.V10;

namespace Sprint6Task5
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}