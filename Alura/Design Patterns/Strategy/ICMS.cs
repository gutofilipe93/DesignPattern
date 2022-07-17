namespace Strategy
{
    public class ICMS : Imposto
    {
        public decimal Calcular(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05M + 50;
        }
    }
}