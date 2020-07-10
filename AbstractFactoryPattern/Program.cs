using System;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main()
        {
            var productFactory = new ProductFactory();

            Console.WriteLine("Dining table");
            
            var diningTable = productFactory.CreateDiningTable();
            
            Console.WriteLine($"Number of legs: {diningTable.GetNumberOfLegs()}");
            Console.WriteLine($"Is foldable: {diningTable.IsFoldable()}");
            
            Console.WriteLine("----------------");
            
            Console.WriteLine("Work chair");

            var workChair = productFactory.CreateWorkChair();
            
            Console.WriteLine($"Number of legs: {workChair.GetNumberOfLegs()}");
            Console.WriteLine($"Has wheels: {workChair.HasWheels()}");
        }
    }
}