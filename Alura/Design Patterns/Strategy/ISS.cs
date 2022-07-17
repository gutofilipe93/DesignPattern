namespace Strategy
{
    public class ISS : Imposto
    {
        public decimal Calcular(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06M;
        }
    }
}