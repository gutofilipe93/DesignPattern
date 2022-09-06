namespace Visitor
{
    public class Numero : IExpressao
    {
        public int Valor {get;set; }   
        public Numero(int Valor)
        {
            this.Valor = Valor;
        }

        public void Aceita(IVisitor impressora)
        {
            impressora.ImprimeNumero(this);
        }

        public int Avalia()
        {
            return Valor;
        }
    }
}