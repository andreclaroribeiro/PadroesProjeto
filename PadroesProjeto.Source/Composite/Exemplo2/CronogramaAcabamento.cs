using System;

namespace PadroesProjeto.Source.Composite
{
    public class CronogramaAcabamento : Cronograma
    {
        public string EmpresaFornecedorJanelas { get; set; }
        public string EmpresaFornecedorPortas { get; set; }

        public void PrintEap()
        {
            Console.WriteLine("Cronograma de Acabamento do Prédio ");
            base.PrintEap();
        }
    }
}