using System;
using System.Collections.Generic;

namespace CommandPattern
{
    // Concrete Commands implement various kinds of requests.
    // A concrete command isn’t supposed to perform the work on its own,
    // but rather to pass the call to one of the business logic objects.
    public class CopyCommand : Command
    {
        private readonly IDictionary<string, object> _options;
        
        public CopyCommand(Editor editor, IDictionary<string, object> options) : base(editor)
        {
            _options = options;
        }
        
        public override void Execute()
        {
            Console.WriteLine("Executing CopyCommand");
            Editor.DoSomething(_options);
        }
    }
}