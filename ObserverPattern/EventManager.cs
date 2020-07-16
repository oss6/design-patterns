using System.Collections.Generic;

namespace ObserverPattern
{
    public class EventManager
    {
        private readonly IDictionary<string, IList<IObserver<string>>> _observers =
            new Dictionary<string, IList<IObserver<string>>>();

        public void Subscribe(string eventType, IObserver<string> observer)
        {
            if (_observers.TryGetValue(eventType, out var observers))
            {
                observers.Add(observer);
            }
            else
            {
                _observers.Add(eventType, new List<IObserver<string>> { observer });
            }
        }

        public void Unsubscribe(string eventType, IObserver<string> observer)
        {
            if (_observers.TryGetValue(eventType, out var observers))
            {
                observers.Remove(observer);
            }
        }

        public void Notify(string eventType, string data)
        {
            if (_observers.TryGetValue(eventType, out var observers))
            {
                foreach (var observer in observers)
                {
                    observer.Update(data);
                }
            }
        }
    }
}