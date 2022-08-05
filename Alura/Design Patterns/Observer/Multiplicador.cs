namespace Observer
{
    public class Multiplicador : AcaoAposGerarNota
    {
        public Multiplicador(double fator)
        {
            Fator = fator;
        }

        public double Fator { get; private set; }
        public void Execultar(NotaFiscal nf)
        {
            Console.WriteLine($"Imprimir valor da nota multiplicado:{Fator * nf.ValorBruto}");
        }
    }
}