namespace Strategy
{
    public class CalculadorDeImposto
    {
        public void RealizarCalculo(Orcamento orcamento, Imposto imposto)
        {
            decimal valor = imposto.Calcular(orcamento);
            Console.WriteLine(valor);
        }
    }
}