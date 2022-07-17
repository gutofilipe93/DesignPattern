namespace Template_Method
{
    public abstract class TemplateDeImpostoCondicional
    {
        public double Calcular(double valor)
        {
            if(DeveUsarMaximaTaxacao(valor))
                return MaximaTaxacao(valor);

            return MinimaTaxacao(valor);
        }

        public abstract bool DeveUsarMaximaTaxacao(double valor);
        public abstract double MaximaTaxacao(double valor);
        public abstract double MinimaTaxacao(double valor);

        public abstract TemplateDeImpostoCondicional Next{get; set;}
        public abstract TemplateDeImpostoCondicional CriarImposto(string tipoImposto);
    }
}