using System;
using Bridge.Abstract;
using Bridge.Control;
using Bridge.Device;

namespace Bridge
{
    /* 
       No exemplo usado não tinha a necessidade de se usar uma classe abstrata para RemoteControl, foi usado mais para tentar simular a implementação 
       quando seu uso foi em um projeto mais complexo.

       E o mais importante de tudo para que ocorra essa liberdade entre as classe é a composição da interface (IDevice) na classe abstrata(RemoteControl), 
       pois atraves é possivel criar varios tipos de dispositivos com varios tipos de controle de uma maneira mais fácil para se da manutenção.
    */
    class Program
    {
        static void Main(string[] args)
        {
            var radio = new Radio();
            RemoteControl remoteControl = new BasicRemoteControl(radio, "Radio");
            remoteControl.Device.SetPower(false);
            var volume = remoteControl.ToggleVolume(12,"-");            
            
            Console.WriteLine($"[{remoteControl.DeviceName}] - Status do dispositivo - {remoteControl.Device.GetPower()}");
            Console.WriteLine($"[{remoteControl.DeviceName}] - Volume que esta o dispositivo - {volume}");

            var tv = new TV();
            var remoteTouchControl = new TouchControl(tv, "TV");
            remoteTouchControl.Device.SetPower(true);
            var volumeTV = remoteTouchControl.ToggleVolume(12,"+");            

            Console.WriteLine($"[{remoteTouchControl.DeviceName}] - Status do dispositivo - {remoteTouchControl.Device.GetPower()}");
            Console.WriteLine($"[{remoteTouchControl.DeviceName}] - Volume que esta o dispositivo - {volumeTV}");
        }
    }
}
