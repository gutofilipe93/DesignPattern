namespace Command
{
    public class LightPowerCommand : ISmartHouseCommand
    {
        private readonly SmartHouseLight _smartHouseLight;
        public LightPowerCommand(SmartHouseLight smartHouseLight)
        {
            _smartHouseLight = smartHouseLight;
        }
        public void Execute()
        {
            _smartHouseLight.On();
        }

        public void Undo()
        {
            _smartHouseLight.Off();
        }        
    }
}