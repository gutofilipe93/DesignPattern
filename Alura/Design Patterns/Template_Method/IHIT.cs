namespace Template_Method
{
    public class IHIT : TemplateDeImpostoCondicional
    {

        public override TemplateDeImpostoCondicional Next { get; set; }

        public override TemplateDeImpostoCondicional CriarImposto(string tipoImposto)
        {
            if(tipoImposto != "IHIT") return Next.CriarImposto(tipoImposto);
            
            return this;
        }

        public override bool DeveUsarMaximaTaxacao(double valor)
        {
            return valor > 2;
        }

        public override double MaximaTaxacao(double valor)
        {
            return ((valor * 0.13) + 100);
        }

        public override double MinimaTaxacao(double valor)
        {
            return valor * 0.01;
        }
    }
}