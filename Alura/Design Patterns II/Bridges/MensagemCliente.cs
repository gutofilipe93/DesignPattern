namespace Bridges
{
    public class MensagemCliente : IMensagem
    {
        public IEnviador Enviador { get; set; }
        private string _nome;
        public MensagemCliente(string name)
        {
            this._nome = name;
        }

        public void Envia()
        {
            this.Enviador.Envia(this);
        }

        public string Formata()
        {
            return String.Format("Mensagem para o cliente {0}", _nome);    
        }
    }
}