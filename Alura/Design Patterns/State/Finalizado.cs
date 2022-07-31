namespace State
{
    public class Finalizado : EstadoDeUmOrcamento
    {
        public void AplicarDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orçamentos finalizados não recebem desconto extra!");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento está em estado de finalizado e não pode ser aprovado");
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orçamento está em estado de finalizado e não pode ser finalizado");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento está em estado de finalizado e não pode ser reprovado");
        }
    }
}