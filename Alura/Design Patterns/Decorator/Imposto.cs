namespace Decorator
{
    public abstract class Imposto
    {
        private Imposto? _outroImposto;
        protected Imposto(Imposto outroImposto)
        {
            _outroImposto = outroImposto;
        }

        protected Imposto(){
            _outroImposto = null;
        }

        public abstract decimal Calcular(Orcamento orcamento);

        protected decimal CalcularOutroImposto(Orcamento orcamento)
        {
            if(_outroImposto == null) return 0;

            return _outroImposto.Calcular(orcamento);
        }
    }
}