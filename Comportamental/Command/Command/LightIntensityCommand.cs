using System;

namespace Command
{
    public class LightIntensityCommand : ISmartHouseCommand
    {
        private readonly SmartHouseLight _smartHouseLight;
        public LightIntensityCommand(SmartHouseLight smartHouseLight)
        {
            _smartHouseLight = smartHouseLight;
        }

        public void Execute()
        {
            var intensity = _smartHouseLight.IncreaseIntensity();
            Console.WriteLine($"Intensidade de {_smartHouseLight.Name} é {intensity}");
        }

        public void Undo()
        {
            var intensity =_smartHouseLight.DecreaseIntensity();
            Console.WriteLine($"Intensidade de {_smartHouseLight.Name} é {intensity}");
        }
    }
}