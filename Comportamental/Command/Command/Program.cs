using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            //Receiver
            var bedroomLight = new SmartHouseLight("Luz Quarto");
            var bathroomLight = new SmartHouseLight("Luz do banheiro");            

            //Command
            var bedroomPowerCommand = new LightPowerCommand(bedroomLight);
            var bathroomPowerCommand = new LightPowerCommand(bathroomLight);
            var bedroomIntensityCommand = new LightIntensityCommand(bedroomLight);

            // Controle - Invoker
            var smartHouseApp = new SmartHouseApp();
            smartHouseApp.AddCommand("btn-1", bedroomPowerCommand);
            smartHouseApp.AddCommand("btn-2", bathroomPowerCommand);
            smartHouseApp.AddCommand("btn-3", bedroomIntensityCommand);
            
            smartHouseApp.ExecuteCommand("btn-1");
            smartHouseApp.ExecuteCommand("btn-2");

            smartHouseApp.UndoCommand("btn-1");
            smartHouseApp.UndoCommand("btn-2");

            for (int i = 0; i < 5; i++)            
                smartHouseApp.ExecuteCommand("btn-3");

            for (int i = 0; i < 3; i++)
                smartHouseApp.UndoCommand("btn-3");
            
        }
    }
}
