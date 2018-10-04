using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            description = "Espresso";
        }

        public override double Cost() => 1.99;
    }
}
