using Bridge.Abstract;
using Bridge.Interface;

namespace Bridge.Control
{
    public class TouchControl : RemoteControl
    {

        public TouchControl(IDevice device, string deviceName)
        {
            Device = device;
            DeviceName = deviceName;
        }

        public override int ToggleVolume(int value, string type)
        {
            if(type == "+")
                value++;
            else if(type == "-")
                value--;

            return value;  
        }
    }
}