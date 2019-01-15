namespace PadroesProjeto.Source.Template_Method
{
    public  class Padeiro
    {
        public void FazerBolo(EBolo.TipoBolo tipoBolo)
        {
            var bolo = new Bolo(tipoBolo);

            bolo.FazerBolo();
        }
    }
}