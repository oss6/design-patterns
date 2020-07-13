using System;
using System.Collections.Generic;

namespace CommandPattern
{
    // The Receiver class contains some business logic. Almost any object may act as a receiver.
    public class Editor
    {
        public void DoSomething(IDictionary<string, object> options)
        {
            var str = "";

            foreach (var (key, value) in options)
            {
                str += $"{key} = ${value}\n";
            }
            
            Console.WriteLine($"Doing the actual work {str}");
        }
    }
}