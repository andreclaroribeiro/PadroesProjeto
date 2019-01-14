namespace PadroesProjeto.Source.Decorator
{
    public class SorveteComCobertura : ISorvete
    {
        ISorvete s;

        public SorveteComCobertura(ISorvete s)
        {
            this.s = s;
        }

        public double Preco
        {
            get
            {
                return this.s.Preco + 0.50;
            }
        }
    }
}
