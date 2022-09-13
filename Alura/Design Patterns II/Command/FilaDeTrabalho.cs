namespace Command
{
    public class FilaDeTrabalho
    {
        private List<IComando> _comandos;
        public void Adicionar(IComando comando)   
        {
            if(_comandos == null)
                _comandos = new List<IComando>();

            _comandos.Add(comando);
        }

        public void Processar()
        {
            foreach (var item in _comandos)            
                item.Executar();            
        }
    }
}