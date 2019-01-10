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
            //AbstractFactory_Exemplo1();
            //AbstractFactory_Exemplo2();
            //Strategy_Exemplo1();
            Strategy_Exemplo2();
            //Adapter();

            Console.ReadLine();
        }

        static void AbstractFactory_Exemplo1()
        {          
            var factory = FormFactories.ObterFactory();

            var textBox = factory.CriarTextBox();
            textBox.Criar();

            var button = factory.CriarBotao();
            button.Criar();
        }

        static void AbstractFactory_Exemplo2()
        {
            var db = DbFactory.Criar();

            var con = db.CreateConnection();
            con.Open();

            var cmd = db.CreateCommand();
            cmd.Execute();
        }

        static void Strategy_Exemplo1()
        {
            var codigoLocal = 2;
            var pesoProduto = 3;

            var pedidoPadrao = new Pedido(new CalculadorDeFretePadrao(), codigoLocal, pesoProduto);
            Console.WriteLine($"Cálculo frete padrão {pedidoPadrao.CalcularFrete()}");

            var pedidoExpresso = new Pedido(new CalculadorDeFreteExpresso(), codigoLocal, pesoProduto);
            Console.WriteLine($"Cálculo frete expresso {pedidoExpresso.CalcularFrete()}");
        }

        static void Strategy_Exemplo2()
        {
            double percentualComissao = 5;
            double totalNormal = 5000;
            double totalEspecial = 6000;

            var conteudo = new Conteudo(new ComissaoIndividual());
            double comissaoVendedor = conteudo.CalculaComissao(totalNormal, percentualComissao);

            conteudo = new Conteudo(new ComissaoConjunta());

            comissaoVendedor += conteudo.CalculaComissao(totalEspecial, percentualComissao);

            Console.WriteLine($"Comissão total: {comissaoVendedor}");
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