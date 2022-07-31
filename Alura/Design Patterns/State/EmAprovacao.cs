namespace State
{
    public class EmAprovacao : EstadoDeUmOrcamento
    {
        private bool _naoAplicouDesconto = true;
        public void AplicarDescontoExtra(Orcamento orcamento)
        {
            if(_naoAplicouDesconto)
                orcamento.Valor -= orcamento.Valor *0.05m;

            _naoAplicouDesconto = false;    
        }

        public void Aprova(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Aprovado();
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }

        public void Reprova(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Reprovado();    
        }
    }
}