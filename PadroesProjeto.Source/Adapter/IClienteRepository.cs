using System.Collections.Generic;

namespace PadroesProjeto.Source.Adapter
{
    public interface IClienteRepository
    {
        IList<Cliente> GetClientes();
    }
}