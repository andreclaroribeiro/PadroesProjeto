namespace PadroesProjeto.Source.Template_Method
{
    public abstract class BoloBase
    {
        public void FazerBolo()
        {
            Passo1();
            Passo2();
        }

        public abstract void Passo1();

        public abstract void Passo2();
    }
}