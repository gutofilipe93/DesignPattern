using System;

namespace Memento
{
    public interface IMemento
    {
         string GetName();
         DateTime GetDate();
    }
}