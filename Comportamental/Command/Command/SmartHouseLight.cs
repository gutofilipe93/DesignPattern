using System;

namespace Command
{
    public class SmartHouseLight
    {
        private bool _isOn = false;
        private int _intensity = 50;
        public string Name = string.Empty;
        public SmartHouseLight(string name)
        {
            Name = name;
        }

        public string getPowerStatus()
        {
            return _isOn ? "ON" : "OFF";
        }

        public bool On()
        {
            _isOn = true;
            Console.WriteLine($"{Name} agora esta {getPowerStatus()}");
            return _isOn;
        }

        public bool Off()
        {
            _isOn = false;
            Console.WriteLine($"{Name} agora esta {getPowerStatus()}");
            return _isOn;
        }

        public int IncreaseIntensity()
        {
            if(_intensity >= 100)
                return _intensity;

            _intensity += 1;
            return _intensity;    
        }

        public int DecreaseIntensity()
        {
            if(_intensity <= 0)
                return _intensity;

            _intensity -= 1;
            return _intensity;    
        }
    }
}