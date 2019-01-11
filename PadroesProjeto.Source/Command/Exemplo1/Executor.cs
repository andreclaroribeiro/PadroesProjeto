using System;
using System.Collections.Generic;

namespace PadroesProjeto.Source.Command
{
    public class Executor
    {
        public void Executar(IEnumerable<IComando> comandos)
        {
            foreach (var comando in comandos)
                comando.Executar();
        }
    }
}