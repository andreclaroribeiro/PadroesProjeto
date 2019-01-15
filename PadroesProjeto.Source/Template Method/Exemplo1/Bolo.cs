using System;

namespace PadroesProjeto.Source.Template_Method
{
    public class Bolo : BoloBase
    {
        private EBolo.TipoBolo _tipoBolo;

        public Bolo(EBolo.TipoBolo tipoBolo)
        {
            _tipoBolo = tipoBolo;
        }

        public override void Passo1()
        {
            if (EBolo.TipoBolo.Chocolate == _tipoBolo)
            {
                Console.WriteLine("Pega os ingredientes do bolo de chocolate");
            }
            else if (EBolo.TipoBolo.Morango == _tipoBolo)
            {
                Console.WriteLine("Pega os ingredientes do bolo de morango");
            }
        }

        public override void Passo2()
        {
            if (EBolo.TipoBolo.Chocolate == _tipoBolo)
            {
                Console.WriteLine("Mistura os ingredientes de chocolate e leva ao forno");
            }
            else if (EBolo.TipoBolo.Morango == _tipoBolo)
            {
                Console.WriteLine("Mistura os ingredientes de morango e leva ao forno");
            }
        }
    }
}