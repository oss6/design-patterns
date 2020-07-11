using System.Collections.Generic;

namespace CompositePattern
{
    public class CompoundGraphic : IGraphic
    {
        private IList<IGraphic> _children = new List<IGraphic>();

        public void Add(IGraphic child)
        {
            _children.Add(child);
        }

        public void Remove(IGraphic child)
        {
            _children.Remove(child);
        }
        
        public void Move(int x, int y)
        {
            foreach (var child in _children)
            {
                child.Move(x, y);
            }
        }

        public void Draw()
        {
            foreach (var child in _children)
            {
                child.Draw();
            }
        }
    }
}