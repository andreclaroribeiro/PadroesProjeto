namespace PadroesProjeto.Source.Decorator
{
    public class SorveteComBalinha : ISorvete
    {
        ISorvete s;

        public SorveteComBalinha(ISorvete s)
        {
            this.s = s;
        }

        public double Preco
        {
            get
            {
                return this.s.Preco + 0.75;
            }
        }
    }
}