namespace Decorator
{
    public class ICMS : Imposto
    {
        public ICMS(){}
        public ICMS(Imposto outroImposto) : base(outroImposto){}

        public override decimal Calcular(Orcamento orcamento)
        {
            return (orcamento.Valor * 0.05M + 50) + CalcularOutroImposto(orcamento);
        }
    }
}