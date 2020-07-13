using System;

namespace FlyweightPattern
{
    class Program
    {
        static void Main()
        {
            var book1 = new Book("Sun Tzu", "Mondadori", "L'arte della guerra", DateTime.Now);
            
            Console.WriteLine(book1);
            
            var book2 = new Book("Sun Tzu", "Mondadori", "Something", DateTime.Now);
            
            Console.WriteLine(book2);
        }
    }
}