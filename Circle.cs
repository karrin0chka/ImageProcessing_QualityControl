namespace ОИ_Практика1
{
    internal class Circle
    {
        private int y;
        private int v;

        public Circle(int x, int y, int v)
        {
            X = x;
            this.y = y;
            this.v = v;
        }

        public int Radius { get; internal set; }
        public int X { get; internal set; }
        public int Y { get; internal set; }
    }
}