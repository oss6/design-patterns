namespace CompositePattern
{
    public class Point : IGraphic
    {
        private int _x;
        private int _y;

        public Point(int x, int y)
        {
            _x = x;
            _y = y;
        }


        public void Move(int x, int y)
        {
            _x += x;
            _y += y;
        }

        public void Draw()
        {
            
        }
    }
}