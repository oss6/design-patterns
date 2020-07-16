using System;

namespace ObserverPattern
{
    public class EmailAlertsObserver : IObserver<string>
    {
        public void Update(string context)
        {
            Console.WriteLine($"EmailAlertsObserver: {context}");
        }
    }
}