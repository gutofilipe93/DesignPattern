namespace Visitor
{
    public class Subtracao : IExpressao
    {
        public IExpressao Esquerda {get; set;}
        public IExpressao Direita {get; set;}
        public Subtracao(IExpressao esquerda, IExpressao direita)
        {
            this.Esquerda = esquerda;
            this.Direita = direita;
        }

        public int Avalia()
        {
            int resultadoDaEsquerda = Esquerda.Avalia();
            int resultadoDaDireita = Direita.Avalia();
            return resultadoDaEsquerda - resultadoDaDireita;
        }

        public void Aceita(IVisitor impressora)
        {
            impressora.ImprimeSubtracao(this);
        }
    }
}