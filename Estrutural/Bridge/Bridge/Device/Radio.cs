using Bridge.Interface;

namespace Bridge.Device
{
    public class Radio : IDevice 
    {

        private bool _powerStatus = false;
         public bool GetPower()
        {
            return _powerStatus;
        }

        public void SetPower(bool status)
        {
            _powerStatus = _powerStatus ? false : true;
        }
    }
}