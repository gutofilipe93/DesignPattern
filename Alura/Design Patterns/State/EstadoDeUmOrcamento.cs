namespace State
{
    public interface EstadoDeUmOrcamento
    {
         void AplicarDescontoExtra(Orcamento orcamento);
         void Aprova(Orcamento orcamento);
         void Reprova(Orcamento orcamento);
         void Finaliza(Orcamento orcamento);
    }
}