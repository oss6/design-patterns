using System;
using System.Collections.Generic;
using System.Linq;

namespace MementoPattern
{
    // The Caretaker knows not only “when” and “why” to capture the originator’s state,
    // but also when the state should be restored.
    public class EditorHistory
    {
        private readonly IList<Editor.Snapshot> _snapshots = new List<Editor.Snapshot>();
        private readonly Editor _editor;

        public EditorHistory(Editor editor)
        {
            _editor = editor;
        }

        public void Backup()
        {
            Console.WriteLine("EditorHistory: Saving Originator's state...");
            _snapshots.Add(_editor.Save());
        }

        public void Undo()
        {
            if (_snapshots.Count == 0)
            {
                return;
            }

            var snapshot = _snapshots.Last();

            _snapshots.Remove(snapshot);
            
            Console.WriteLine($"EditorHistory: Restoring state to: {snapshot}");
            
            _editor.Restore(snapshot);
        }
        
        public void ShowHistory()
        {
            Console.WriteLine("EditorHistory: Here's the list of snapshots:");

            foreach (var snapshot in _snapshots)
            {
                Console.WriteLine(snapshot);
            }
        }
    }
}