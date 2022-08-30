namespace Memento
{
    public class Historico
    {
        private IList<Contrato> Contratos = new List<Contrato>();

        public Contrato Pega(int index) 
        {
            return Contratos[index];
        }

        public void Adiciona(Contrato contrato) 
        {
            Contratos.Add(contrato);
        } 
        
    }
}