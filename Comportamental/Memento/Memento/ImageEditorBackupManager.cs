using System;
using System.Collections.Generic;
using System.Linq;

namespace Memento
{
    public class ImageEditorBackupManager
    {
        private List<IMemento> _mementos = new List<IMemento>();
        private ImageEditor _imageEditor;
        public ImageEditorBackupManager(ImageEditor imageEditor)
        {
            _imageEditor = imageEditor;
        }

        public void Backup()
        {
            Console.WriteLine("Backup Salvando o estado o ImageEditor");
            _mementos.Add(_imageEditor.Save());
        }

        public void Undo()
        {
            var memento = _mementos.FirstOrDefault();            
            if(memento == null)
            {
                Console.WriteLine("Backup: no Memento");
                return;
            }

            _imageEditor.Restore(memento);
            _mementos.Remove(memento);
            Console.WriteLine($"{memento.GetName()} foi restaurado com sucesso");
        }        
    }
}