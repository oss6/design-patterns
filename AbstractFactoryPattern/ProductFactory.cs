using AbstractFactoryPattern.Products;

namespace AbstractFactoryPattern
{
    public class ProductFactory : IProductFactory
    {
        public IChair CreateWorkChair()
        {
            return new WorkChair();
        }

        public ITable CreateDiningTable()
        {
            return new DiningTable();
        }
    }
}