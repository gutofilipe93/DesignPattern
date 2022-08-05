namespace Observer
{
    public class EnviadorDeSms : AcaoAposGerarNota
    {
        public void Execultar(NotaFiscal nf)
        {
            Console.WriteLine("enviando por sms");
        }
    }
}