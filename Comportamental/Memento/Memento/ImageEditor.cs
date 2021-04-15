using System;

namespace Memento
{
    //Originator
    public class ImageEditor
    {
        public string FilePath { get; private set;}        
        public string FileFormat {get; private set;}
        public ImageEditor(string filePath, string fileFormat)
        {
            FilePath = filePath;
            FileFormat = fileFormat;
        }

        public void ConvertFormatTo(string format)
        {
            FileFormat = format;
            FilePath = FilePath.Replace(".jpg", "." + format);
        }

        public IMemento Save()
        {
            return new ConcreteMemento(DateTime.Now.ToString(), FilePath,FileFormat,DateTime.Now);
        }

        public void Restore(IMemento memento)
        {
            var concreteMemento = (ConcreteMemento)memento;
            FileFormat = concreteMemento.GetFileFormat();
            FilePath = concreteMemento.GetFilePath();
        }
    }
}