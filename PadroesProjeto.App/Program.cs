using PadroesProjeto.Source.AbstractFactory;
using PadroesProjeto.Source.Adapter;
using PadroesProjeto.Source.Strategy;
using System;
using System.Linq;

namespace PadroesProjeto.App
{
    class Program
    {
        static void Main(string[] args)
        {
            //AbstractFactory();
            //Strategy();
            Adapter();

            Console.ReadLine();
        }

        static void AbstractFactory()
        {            
            //DbFactory db = new SqlFactory();
            DbFactory db = new MongoFactory();

            var con = db.CreateConnection();
            con.Open();

            var cmd = db.CreateCommand();
            cmd.Execute();
        }

        static void Strategy()
        {
            var codigoLocal = 2;
            var pesoProduto = 3;

            var pedidoPadrao = new Pedido(new CalculadorDeFretePadrao(), codigoLocal, pesoProduto);
            Console.WriteLine($"Cálculo frete padrão {pedidoPadrao.CalcularFrete()}");

            var pedidoExpresso = new Pedido(new CalculadorDeFreteExpresso(), codigoLocal, pesoProduto);
            Console.WriteLine($"Cálculo frete expresso {pedidoExpresso.CalcularFrete()}");
        }

        static void Adapter()
        {
            var repository = new ClienteRepository();
            var httpCache = new HttpContextCacheStorage();

            var service = new ClienteService(repository, httpCache);
            var clientes = service.GetAllClientes();

            clientes.ToList().ForEach(x => Console.WriteLine($"{x.Nome}"));
        }
    }
}