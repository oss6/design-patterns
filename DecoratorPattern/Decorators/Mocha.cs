namespace DecoratorPattern.Decorators
{
    public class Mocha : CondimentDecorator
    {
        private readonly Beverage _beverage;

        public Mocha(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string GetDescription()
            => _beverage.GetDescription() + ", Mocha";

        public override double Cost()
            => .20 + _beverage.Cost();
    }
}
