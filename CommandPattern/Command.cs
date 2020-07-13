namespace CommandPattern
{
    public abstract class Command
    {
        protected Editor Editor;

        public Command(Editor editor)
        {
            Editor = editor;
        }
        
        public abstract void Execute();
    }
}