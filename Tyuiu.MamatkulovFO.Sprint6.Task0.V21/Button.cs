namespace Tyuiu.MamatkulovFO.Sprint6.Task0.V21
{
    internal class Button
    {
        public string Text { get; set; }
        public int Left { get; set; }
        public int Top { get; set; }
        public int Width { get; set; }
        public Action<object, object> Click { get; internal set; }
    }
}