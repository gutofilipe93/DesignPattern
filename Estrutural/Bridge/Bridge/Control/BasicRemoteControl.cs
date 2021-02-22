using Bridge.Abstract;
using Bridge.Interface;

namespace Bridge.Control
{
    public class BasicRemoteControl : RemoteControl
    {
        public BasicRemoteControl(IDevice device, string deviceName)
        {
            Device = device;
            DeviceName = deviceName;
        }

        public override int ToggleVolume(int value, string type)
        {
            if(type == "+")
                value+= 10;
            else if(type == "-")
                value-= 10;

            return value;        
        }
    }
}