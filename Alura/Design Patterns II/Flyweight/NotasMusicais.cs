namespace Flyweight
{
    public class NotasMusicais
    {
        private static IDictionary<string, INota> NOTAS = new Dictionary<string,INota>()
        {
            { "do", new Do() } ,
            { "re", new Re() } ,
            { "mi", new Mi() },
            { "fa", new Fa() },
            { "sol", new Sol() },
            { "la", new La() },
            { "si", new Si() }
        };

        public INota ObterNota(string nome)
        {
            return NOTAS[nome];
        }
    }
}