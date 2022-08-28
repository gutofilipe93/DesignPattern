namespace Flyweight
{
    public class Piano
    {
        public void Tocar(List<INota> notas)
        {
            foreach (var nota in notas)
            {
                Console.Beep(nota.Frequencia, 300);
            }
        }
    }
}