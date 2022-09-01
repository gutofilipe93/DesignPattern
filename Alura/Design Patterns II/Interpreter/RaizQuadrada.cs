namespace Interpreter
{
    public class RaizQuadrada : IExpressao
    {
        public RaizQuadrada(IExpressao value)
        {
            Value = value;
        }

        public IExpressao Value { get; private set; }
        public int Avalia()
        {
            int valueResult = Value.Avalia();
            return (int)Math.Sqrt(valueResult);
        }
    }
}