using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var singletonInstance1 = Singleton.GetInstance();
            var singletonInstance2 = Singleton.GetInstance();

            Console.WriteLine(singletonInstance1 == singletonInstance2);
            Console.ReadKey();
        }
    }
}
