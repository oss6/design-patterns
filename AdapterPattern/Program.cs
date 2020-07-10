using System;

namespace AdapterPattern
{
    class Program
    {
        static void Main()
        {
            var api = new ExternalApi();
            var target = new Adapter(api);
            
            Console.WriteLine("Adaptee interface is incompatible with the client.");
            Console.WriteLine("But with adapter client can call it's method.");

            Console.WriteLine(target.GetRequest());
        }
    }
}