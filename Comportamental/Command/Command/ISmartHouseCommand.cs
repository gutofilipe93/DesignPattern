namespace Command
{
    public interface ISmartHouseCommand
    {
         void Execute();
         void Undo();
    }
}