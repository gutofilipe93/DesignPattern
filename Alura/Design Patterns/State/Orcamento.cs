namespace State
{
    public class Orcamento
    {
        public Orcamento(decimal valor)
        {
            Valor = valor;
            EstadoAtual = new EmAprovacao();
        }

        public decimal Valor { get; set; }
        public EstadoDeUmOrcamento EstadoAtual { get; set; }

        public void AplicarDescontoExtra()
        {
            EstadoAtual.AplicarDescontoExtra(this);
        }

        public void Aprova()
        {
            EstadoAtual.Aprova(this);
        }

        public void Reprova()
        {
            EstadoAtual.Reprova(this);
        }

        public void Finaliza()
        {
            EstadoAtual.Finaliza(this);
        }

    }
}