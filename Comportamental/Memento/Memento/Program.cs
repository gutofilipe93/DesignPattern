using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            var imageEditor = new ImageEditor("/media/image.png", ".png");
            var backupManager = new ImageEditorBackupManager(imageEditor);

            Console.WriteLine($"{imageEditor.FilePath} - {imageEditor.FileFormat}");
            backupManager.Backup();
            imageEditor.ConvertFormatTo("gif");
            Console.WriteLine($"{imageEditor.FilePath} - {imageEditor.FileFormat}");
            backupManager.Undo();            
            Console.WriteLine($"{imageEditor.FilePath} - {imageEditor.FileFormat}");
        }        
    }
}
