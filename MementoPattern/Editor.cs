using System;
using System.Threading;

namespace MementoPattern
{
    // The Originator class can produce snapshots of its own state,
    // as well as restore its state from snapshots when needed.
    public class Editor
    {
        private string _state;

        public Editor(string state)
        {
            _state = state;
        }
        
        public void DoSomething()
        {
            Console.WriteLine("Originator: I'm doing something important.");
            _state = GenerateRandomString(30);
            Console.WriteLine($"Originator: and my state has changed to: {_state}");
        }

        public Snapshot Save() => new Snapshot(_state);

        public void Restore(Snapshot snapshot) => _state = snapshot.GetState();

        private static string GenerateRandomString(int length = 10)
        {
            const string allowedSymbols = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var result = string.Empty;

            while (length > 0)
            {
                result += allowedSymbols[new Random().Next(0, allowedSymbols.Length)];

                Thread.Sleep(12);

                length--;
            }

            return result;
        }
        
        public class Snapshot
        {
            private readonly string _state;
            private DateTime _date;

            public Snapshot(string state)
            {
                _state = state;
                _date = DateTime.Now;
            }

            public string GetState() => _state;

            public DateTime GetDate() => _date;

            public override string ToString() => $"{_date} / ({_state.Substring(0, 9)})...";
        }
    }
}