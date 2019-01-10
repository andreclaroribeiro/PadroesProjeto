using System.Collections.Generic;

namespace PadroesProjeto.Source.Adapter
{
    public class ClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly ICacheStorage _cacheStorage;

        public ClienteService(IClienteRepository clienteRepository, 
                              ICacheStorage cacheStorage)
        {
            _clienteRepository = clienteRepository;
            _cacheStorage = cacheStorage;
        }

        public IList<Cliente> GetAllClientes()
        {
            IList<Cliente> clientes;
            string storageKey = "GetAllClientes";
            clientes = _cacheStorage.Retrieve<List<Cliente>>(storageKey);
            if (clientes == null)
            {
                clientes = _clienteRepository.GetClientes();
                _cacheStorage.Store(storageKey, clientes);
            }

            return clientes;
        }
    }
}