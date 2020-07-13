using System;

namespace CommandPattern
{
    // The Sender class (aka invoker) is responsible for initiating requests.
    // This class must have a field for storing a reference to a command object. 
    public class CopyButton
    {
        private Command _command;

        public void SetCommand(Command command)
        {
            _command = command;
        }

        public void Click()
        {
            Console.WriteLine("Clicked copy button");
            _command.Execute();
        }
    }
}