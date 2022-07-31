namespace State
{
    public class Aprovado : EstadoDeUmOrcamento
    {
        private bool _naoAplicouDesconto = true;
        public void AplicarDescontoExtra(Orcamento orcamento)
        {
            if(_naoAplicouDesconto)
                orcamento.Valor -= orcamento.Valor * 0.02m;
            
            _naoAplicouDesconto = false;    
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está em estado de aprovação");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento está em estado de aprovação e não pode ser reprovado");
        }
    }
}