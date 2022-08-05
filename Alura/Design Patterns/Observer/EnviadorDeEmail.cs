namespace Observer
{
    public class EnviadorDeEmail : AcaoAposGerarNota
    {
        public void Execultar(NotaFiscal nf)
        {
            Console.WriteLine("enviando por e-mail");
        }
    }
}