using System;

using Tyuiu.MamatkulovFO.Sprint6.Task6.V16.Lib;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.MamatkulovFO.Sprint6.Task6.V16
{
    static class Program
    {
        private static readonly object DialogResult;

        public static object MessageBox { get; private set; }

        [STAThread]
        static void Main()
        {
          

            var ofd = new OpenFileDialog { Filter = "Text files|*.txt" };
            if (ofd.ShowDialog() == DialogResult)
            {
                try
                {
                    var result = new DataService().GetWordsWithB(ofd.FileName);
                    
                }
                catch (Exception ex)
                {
                  
                }
            }
        }
    }
}