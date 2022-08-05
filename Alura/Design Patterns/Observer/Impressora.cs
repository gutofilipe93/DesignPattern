namespace Observer
{
    public class Impressora : AcaoAposGerarNota
    {
        public void Execultar(NotaFiscal nf)
        {
            Console.WriteLine("Imprimindo nota fiscal");
        }
    }
}