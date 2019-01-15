namespace PadroesProjeto.Source.Flyweight
{
    public class Ponto
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public Ponto(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}