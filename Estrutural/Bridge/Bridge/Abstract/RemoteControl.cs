using Bridge.Interface;

namespace Bridge.Abstract
{
    public abstract class  RemoteControl
    {
        public string DeviceName { get; set; }
        public IDevice Device { get; set; }
        public abstract int ToggleVolume(int value, string type);
    }
}