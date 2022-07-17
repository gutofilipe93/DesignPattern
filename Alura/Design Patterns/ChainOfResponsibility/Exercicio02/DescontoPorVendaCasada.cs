using ChainOfResponsibility.Exercicio01;

namespace ChainOfResponsibility.Exercicio02
{
    public class DescontoPorVendaCasada : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public decimal TotalDesconto(Cupom cupom)
        {
            if(Existe("LAPIS", cupom) && Existe("CANETA",cupom))
                return cupom.GetTotal() * 0.05M;

            return Proximo.TotalDesconto(cupom);    
        }


        private bool Existe(String nomeDoItem, Cupom cupom)
        {
            foreach (var item in cupom.Items)
            {
                if (item.Nome.Equals(nomeDoItem))
                    return true;
            }
            return false;
        }

    }
}