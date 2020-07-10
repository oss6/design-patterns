using AbstractFactoryPattern.Products;

namespace AbstractFactoryPattern
{
    public interface IProductFactory
    {
        IChair CreateWorkChair();
        ITable CreateDiningTable();
    }
}