namespace Decorator
{
    public class ImpostoMtoAlto : Imposto
    {
        public ImpostoMtoAlto(){}
        public ImpostoMtoAlto(Imposto outroImposto) : base(outroImposto){}

        public override decimal Calcular(Orcamento orcamento)
        {
            return (orcamento.Valor * 0.2m) + CalcularOutroImposto(orcamento) ;
        }
    }
}