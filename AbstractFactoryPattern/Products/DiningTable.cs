namespace AbstractFactoryPattern.Products
{
    public class DiningTable : ITable
    {
        public bool IsFoldable()
        {
            return false;
        }

        public int GetNumberOfLegs()
        {
            return 4;
        }
    }
}