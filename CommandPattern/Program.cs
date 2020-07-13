using System.Collections.Generic;

namespace CommandPattern
{
    class Program
    {
        static void Main()
        {
            var editor = new Editor();
            var copyCommand = new CopyCommand(editor, new Dictionary<string, object> { { "config", true } });
            
            var copyButton = new CopyButton();
            copyButton.SetCommand(copyCommand);

            copyButton.Click();
        }
    }
}