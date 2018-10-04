namespace DecoratorPattern
{
    public abstract class Beverage
    {
        protected string description = "N.A.";

        public virtual string GetDescription() => description;

        public abstract double Cost();
    }
}
