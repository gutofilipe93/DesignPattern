namespace Observer
{
    public class NotaFiscalDao : AcaoAposGerarNota
    {
        public void Execultar(NotaFiscal nf)
        {
            Console.WriteLine("Salvando no banco de dados");
        }
    }
}