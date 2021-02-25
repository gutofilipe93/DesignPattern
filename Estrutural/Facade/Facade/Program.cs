using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            ComputadorFacade computadorFacade = new ComputadorFacade();
            computadorFacade.MontarPC();
        }
    }
}
