namespace MementoPattern
{
    class Program
    {
        static void Main()
        {
            var editor = new Editor("this is a nice string");
            var editorHistory = new EditorHistory(editor);
            
            editorHistory.Backup();
            editor.DoSomething();
            
            editorHistory.Backup();
            editor.DoSomething();
            
            editorHistory.ShowHistory();
        }
    }
}