using System;

namespace Memento
{
    public class ConcreteMemento : IMemento
    {
        private string _name;
        private string _filePath;
        private string _fileFormat;
        private DateTime _date;
        public ConcreteMemento(string name, string filePath, string fileFormat, DateTime date)
        {
            _name = name; 
            _fileFormat = fileFormat;
            _filePath = filePath;
            _date = date;
        }

        public DateTime GetDate()
        {
            return _date;
        }

        public string GetName()
        {
            return _name;
        }

        public string GetFilePath()
        {
            return _filePath;
        }

        public string GetFileFormat()
        {
            return _fileFormat;
        }
    }
}