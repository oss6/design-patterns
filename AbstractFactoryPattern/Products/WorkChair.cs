namespace AbstractFactoryPattern.Products
{
    public class WorkChair : IChair
    {
        public int GetNumberOfLegs()
        {
            return 5;
        }

        public bool HasWheels()
        {
            return true;
        }
    }
}