using System;

namespace ObserverPattern
{
    public class LoggingObserver : IObserver<string>
    {
        public void Update(string context)
        {
            Console.WriteLine($"LoggingObserver: {context}");
        }
    }
}