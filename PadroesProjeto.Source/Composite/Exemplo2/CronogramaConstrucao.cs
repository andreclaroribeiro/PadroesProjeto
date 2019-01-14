using System;

namespace PadroesProjeto.Source.Composite
{
    public class CronogramaConstrucao : Cronograma
    {
        public string NomeConstrutora { get; set; }

        public void PrintEap()
        {
            Console.WriteLine("Cronograma de Construcao " + this.NomeConstrutora);
            base.PrintEap();
        }
    }
}