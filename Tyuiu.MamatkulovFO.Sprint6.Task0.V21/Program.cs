using Tyuiu.MamatkulovFO.Sprint6.Task0.V21.Lib;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.MamatkulovFO.Sprint6.Task0.V21
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
           

            var form = new Form { Text = "V21", Width = 300, Height = 180 };
            var textBox = new TextBox { Left = 20, Top = 40, Width = 230, ReadOnly = true };
            var button = new Button { Text = "Hisoblash", Left = 20, Top = 80, Width = 100 };

            button.Click += (s, e) =>
            {
                double result = new DataService().Calculate(2);
                textBox.Text = result.ToString("F3");
            };

           
        }
    }
}