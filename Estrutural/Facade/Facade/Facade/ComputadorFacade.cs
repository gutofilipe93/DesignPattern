using System;
using Facade.PC;

namespace Facade
{
    public class ComputadorFacade
    {
        private Memoria _memoria;
        private HD _hd;
        private CPU _cpu;
        private SO _so;
        private Acessorios _acessorios;

        public ComputadorFacade()
        {
            _memoria = new Memoria();
            _hd = new HD();
            _cpu = new CPU();
            _so = new SO();
            _acessorios = new Acessorios();
        }

        public void MontarPC()
        {
            Console.WriteLine("Montando uma nova maquina");

            _memoria.AdicionarMemoria();
            _cpu.AdicionarProcessador();
            _hd.AdicionarHD();
            _acessorios.AdicionarMonitor();
            _acessorios.AdicionarMouse();
            _acessorios.AdicionarTeclado();
            _so.InstalarSO();

            Console.WriteLine("Computador finalizado ");
        }

    }
}