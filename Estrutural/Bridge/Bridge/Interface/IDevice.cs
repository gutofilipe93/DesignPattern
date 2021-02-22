namespace Bridge.Interface
{
    public interface IDevice
    {        
        void SetPower(bool status);
        bool GetPower();
    }
}