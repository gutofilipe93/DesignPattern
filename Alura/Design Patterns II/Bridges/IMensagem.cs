namespace Bridges
{
    public interface IMensagem
    {
        public IEnviador Enviador { get; set; }
        void Envia();
        string Formata();
    }
}