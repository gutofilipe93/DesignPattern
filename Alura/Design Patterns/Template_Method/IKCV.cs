namespace Template_Method
{
    public class IKCV : TemplateDeImpostoCondicional
    {

        public override TemplateDeImpostoCondicional Next { get; set; }

        public override TemplateDeImpostoCondicional CriarImposto(string tipoImposto)
        {
            if(tipoImposto != "IKCV") return Next.CriarImposto(tipoImposto);
            
            return this;
        }

        public override bool DeveUsarMaximaTaxacao(double valor)
        {
            return valor > 500;   
        }        

        public override double MaximaTaxacao(double valor)
        {
            return valor*0.1;
        }

        public override double MinimaTaxacao(double valor)
        {
            return valor*0.06;
        }
    }
}