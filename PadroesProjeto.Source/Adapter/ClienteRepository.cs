using System.Collections.Generic;

namespace PadroesProjeto.Source.Adapter
{
    public class ClienteRepository : IClienteRepository
    {
        public IList<Cliente> GetClientes()
        {
            var clientes = new List<Cliente>();

            for (int i = 1; i <= 20; i++)
                clientes.Add(new Cliente { Id = i, Nome = $"Teste nome cliente {i}" });

            return clientes;
        }
    }
}