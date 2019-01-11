using System;

namespace PadroesProjeto.Source.Command
{
    public class SalvarRegistroComando : IComando
    {
        private readonly long _codigo;

        public SalvarRegistroComando(long codigo)
        {
            _codigo = codigo;
        }

        public void Executar()
        {
            Console.WriteLine($"Registro salvo: {_codigo}");
        }
    }
}