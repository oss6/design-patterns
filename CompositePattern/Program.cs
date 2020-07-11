namespace CompositePattern
{
    class Program
    {
        static void Main()
        {
            var graphic = new CompoundGraphic();
            
            graphic.Add(new Point(3, 4));
            graphic.Add(new Point(4, 1));
            graphic.Add(new Point(8, 1));
            
            graphic.Move(1, 1);
            
            graphic.Draw();
        }
    }
}