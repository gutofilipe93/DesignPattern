namespace Decorator
{
    public class ISS : Imposto
    {
        public ISS(Imposto outroImposto) : base(outroImposto){}
        public ISS(){}

        public override decimal Calcular(Orcamento orcamento)
        {
            return (orcamento.Valor * 0.06M) + CalcularOutroImposto(orcamento);
        }       
    }
}