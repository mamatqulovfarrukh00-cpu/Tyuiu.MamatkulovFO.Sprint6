namespace Tyuiu.MamatkulovFO.Sprint6.Task1.V7
{
    internal class Button
    {
        public string Text { get; set; }
        public object Dock { get; set; }
        public Action<object, object> Click { get; internal set; }
    }
}