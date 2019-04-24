namespace IEvangelist.BlazoR.Board.Shared
{
    public class Stroke
    {
        public Point PreviousPoint { get; set; }
        public Point CurrentPoint { get; set; }
        public string Color { get; set; }
    }

    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}