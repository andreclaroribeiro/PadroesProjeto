using PadroesProjeto.Source.AbstractFactory;
using PadroesProjeto.Source.Adapter;
using PadroesProjeto.Source.Bridge;
using PadroesProjeto.Source.Builder;
using PadroesProjeto.Source.Command;
using PadroesProjeto.Source.Composite;
using PadroesProjeto.Source.Decorator;
using PadroesProjeto.Source.Facade;
using PadroesProjeto.Source.Flyweight;
using PadroesProjeto.Source.Iterator;
using PadroesProjeto.Source.Memento;
using PadroesProjeto.Source.Observer;
using PadroesProjeto.Source.Prototype;
using PadroesProjeto.Source.Singleton;
using PadroesProjeto.Source.State;
using PadroesProjeto.Source.Strategy;
using PadroesProjeto.Source.Template_Method;
using PadroesProjeto.Source.Visitor;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PadroesProjeto.App
{
    class Program
    {
        static void Main(string[] args)
        {
            TemplateMethod();

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

        static void Command_Exemplo1()
        {
            var comandos = new List<IComando>
            {
                new LogMensagemComando("Log realizado"),
                new LogEmailComando("Email através de comando"),
                new SalvarRegistroComando(1),
                new SalvarRegistroComando(3)
            };

            var executor = new Executor();
            executor.Executar(comandos);
        }

        static void Facade()
        {
            var pacoteViagemFacade = new PacoteViagemFacade();
            pacoteViagemFacade.Adquirir();
        }

        static void Builder()
        {
            var concessionaria = new ConcessionariaDirector(new FiatBuilder());

            concessionaria.construirCarro();
            var carro = concessionaria.GetCarro();

            Console.WriteLine($"Carro: {carro.Modelo} / {carro.Montadora}" + 
                $" Ano: {carro.AnoFabricacao} Motor: {carro.Motor} Valor: {carro.Preco}");

            Console.WriteLine();

            concessionaria = new ConcessionariaDirector(new VolksBuilder());

            concessionaria.construirCarro();
            carro = concessionaria.GetCarro();

            Console.WriteLine($"Carro: {carro.Modelo} / {carro.Montadora}" +
                $" Ano: {carro.AnoFabricacao} Motor: {carro.Motor} Valor: {carro.Preco}");
        }

        static void Bridge_Exemplo1()
        {
            var bridge = new Bridge();
            var nodeA = new NodeA();
            var nodeB = new NodeB();

            bridge.ReachTo(nodeA); 
            bridge.ReachTo(nodeB); 
        }

        static void Bridge_Exemplo2()
        {
            var mb = new MailSendBridge();
            var csharp = new CSharpMail();
            var vb = new VbMail();
            var database = new DatabaseMail();

            mb.SendFrom(csharp);
            mb.SendFrom(vb);
            mb.SendFrom(database);
        }

        static void Observer_Exemplo1()
        {
            var controlador = new ControladorEmail();
            var usuarioA = new UsuarioA();
            var usuarioB = new UsuarioB();
            var usuarioC = new UsuarioC();

            Console.WriteLine("Os usuarios A, B e C cadastraram-se para receber as promoções. \n");
            usuarioA.Assinar(controlador);
            usuarioB.Assinar(controlador);
            usuarioC.Assinar(controlador);

            Console.WriteLine("Enviando os emails para os usuarios assinados (usuários cadastrados).\n");
            controlador.EnviarEmail();

            Console.WriteLine("\nO usuário A resolveu concancelar a assinatura e não irá receber mais emails.\n");
            usuarioA.CancelarAssinatura(controlador);

            Console.WriteLine("Enviando os emails para os usuarios assinados.\n");
            controlador.EnviarEmail();
        }

        static void Observer_Exemplo2()
        {
            var email = new Email();

            var controladorEmail = new EmailController(email);

            Console.WriteLine("Os usuarios A, B e C cadastraram-se para receber as promoções. \n");

            var userA = new UserA(controladorEmail);
            var userB = new UserB(controladorEmail);
            var userC = new UserC(controladorEmail);

            Console.WriteLine("Enviando os emails para os usuários assinados (usuários cadastrados).\n");

            controladorEmail.EnviarEmail();

            Console.WriteLine("\nO usuário A resolveu cancelar a assinatura e não irá receber mais emails.\n");

            userA.Dispose();

            Console.WriteLine("Enviando os emails para os usuários assinados.\n");
            controladorEmail.EnviarEmail();
        }

        static void Prototype_Exemplo1()
        {
            var p1 = new ConcretePrototype1("I");
            var c1 = (ConcretePrototype1)p1.Clone();
            Console.WriteLine("Cloned: {0}", c1.Id);

            ConcretePrototype2 p2 = new ConcretePrototype2("II");
            ConcretePrototype2 c2 = (ConcretePrototype2)p2.Clone();

            Console.WriteLine("Cloned: {0}", c2.Id);
        }

        static void Prototype_Exemplo2()
        {
            var colormanager = new ColorManager();

            colormanager["red"] = new Color(255, 0, 0);
            colormanager["green"] = new Color(0, 255, 0);
            colormanager["blue"] = new Color(0, 0, 255);

            colormanager["angry"] = new Color(255, 54, 0);
            colormanager["peace"] = new Color(128, 211, 128);
            colormanager["flame"] = new Color(211, 34, 20);

            Color color1 = colormanager["red"].Clone() as Color;
            Color color2 = colormanager["peace"].Clone() as Color;
            Color color3 = colormanager["flame"].Clone() as Color;
        }

        static void Singleton()
        {
            Dispositivo.GetInstance().Marca = "Teste marca";
            Dispositivo.GetInstance().Modelo = "Teste modelo";

            Dispositivo.GetInstance().Ligar();
            Console.WriteLine(Dispositivo.GetInstance().ToString());
            Dispositivo.GetInstance().Desligar();
        }

        static void Composite_Exemplo1()
        {
            var fabricantes = new Fabricante("Fabricantes");
            var Volks = new Fabricante("Volkswagens");

            fabricantes.AcrescentaNaLista(Volks);

            var Peugeot = new Fabricante("Peugeot");

            fabricantes.AcrescentaNaLista(Peugeot);

            var Jetta = new Carro { Modelo = "Jetta" };
            Volks.AcrescentaNaLista(Jetta);

            var Gol = new Carro { Modelo = "Gol" };
            Volks.AcrescentaNaLista(Gol);

            var Peugeot208 = new Carro { Modelo = "Peugeot208" };
            Peugeot.AcrescentaNaLista(Peugeot208);

            var Peugeot408 = new Carro { Modelo = "Peugeot408" };
            Peugeot.AcrescentaNaLista(Peugeot408);

            Console.WriteLine("Fabricantes: ");

            foreach (Fabricante item in fabricantes)
            {
                Console.WriteLine(string.Format("# Fabrica: {0} ", item.Nome));

                foreach (ICarro filho in item)
                {
                    Console.WriteLine(string.Format("-- Modelo: {0} ", filho.Modelo));
                }
            }
        }

        static void Composite_Exemplo2()
        {
            var pacote1 = new Pacote(1, "Pacote1", new decimal(10.0));
            var pacote2 = new Pacote(2, "Pacote2", new decimal(20.0));
            var tarefa1 = new Tarefa(1, "Tarefa1", new decimal(30.0));

            pacote1.SetItemTrabalho(pacote2);
            pacote2.SetItemTrabalho(tarefa1);

            var cro1 = new CronogramaConstrucao
            {
                NomeConstrutora = "RD Empreendimentos",
                Nome = "Construcao Condominio Rio de Janeiro"
            };
            cro1.SetItemTrabalho(pacote1);

            cro1.PrintEap();

            var tarefa10 = new Tarefa(10, "Tarefa 10", new decimal(10.0));
            var tarefa11 = new Tarefa(11, "Tarefa 11", new decimal(10.0));
            var tarefa12 = new Tarefa(12, "Tarefa 12", new decimal(10.0));
            var tarefa13 = new Tarefa(12, "Tarefa 13", new decimal(10.0));

            tarefa10.SetItemTrabalho(tarefa11);
            tarefa11.SetItemTrabalho(tarefa12);
            tarefa12.SetItemTrabalho(tarefa13);

            var cro2 = new CronogramaAcabamento();
            cro2.Nome = "Acabamento Condomino Rio de Janeiro";
            cro2.SetItemTrabalho(tarefa10);

            cro2.PrintEap();
        }

        static void Decorator_Exemplo1()
        {
            var pessoa = new Pessoa();

            Console.WriteLine("usando Pessoa:");
            Console.WriteLine(pessoa.Andar());
            
            Console.WriteLine();

            var pessoaRapida = new PessoaRapida(pessoa);

            Console.WriteLine("usando PessoaRapida:");
            Console.WriteLine(pessoaRapida.Andar());
            Console.WriteLine(pessoaRapida.Correr());

            Console.WriteLine();

            var pessoaLenta = new PessoaLenta(pessoa);

            Console.WriteLine("usando PessoaLenta:");
            Console.WriteLine(pessoaLenta.Andar());
        }

        static void Decorator_Exemplo2()
        {
            var sorvete = new Sorvete();

            Console.WriteLine("Sorvete:");
            Console.WriteLine("{0:c}", sorvete.Preco);
            
            Console.WriteLine();
            
            var sorveteCobertura = new SorveteComCobertura(sorvete);
            
            Console.WriteLine("Sorvete com cobertura:");
            Console.WriteLine("{0:c}", sorveteCobertura.Preco);
            
            Console.WriteLine();
            
            var sorveteBalinha = new SorveteComBalinha(sorvete);

            Console.WriteLine("Sorvete com balinha:");
            Console.WriteLine("{0:c}", sorveteBalinha.Preco);
            
            Console.WriteLine();
            
            var sorveteCoberturaBalinha = new SorveteComCobertura(sorveteBalinha);
            
            Console.WriteLine("Sorvete com cobertura E balinha:");
            Console.WriteLine("{0:c}", sorveteCoberturaBalinha.Preco);
        }

        static void Flyweight_Exemplo1()
        {
            var factory = new FlyweightFactory();

            factory.GetFlyweight(SpritesEnum.Cenario1).DesenharImagem(new Ponto(0, 0));

            factory.GetFlyweight(SpritesEnum.Jogador).DesenharImagem(new Ponto(10, 10));

            factory.GetFlyweight(SpritesEnum.Inimigo1).DesenharImagem(new Ponto(100, 10));
            factory.GetFlyweight(SpritesEnum.Inimigo1).DesenharImagem(new Ponto(120, 10));
            factory.GetFlyweight(SpritesEnum.Inimigo1).DesenharImagem(new Ponto(140, 10));

            factory.GetFlyweight(SpritesEnum.Inimigo2).DesenharImagem(new Ponto(60, 10));
            factory.GetFlyweight(SpritesEnum.Inimigo2).DesenharImagem(new Ponto(50, 10));

            factory.GetFlyweight(SpritesEnum.Inimigo3).DesenharImagem(new Ponto(170, 10));
        }

        static void Iterator_Exemplo1()
        {
            IAgregadoCanal canaisEsporte = new CanalEsporte();

            Console.WriteLine("Canais de Esporte:");

            for (IIterador it = canaisEsporte.CriarIterador(); !it
                    .IsDone(); it.Next())
            {
                Console.WriteLine(it.CurrentItem().Nome);
            }

            IAgregadoCanal canaisFilme = new CanalFilme();
            Console.WriteLine("\nCanais de Filmes:");
            for (IIterador it = canaisFilme.CriarIterador(); !it
                    .IsDone(); it.Next())
            {
                Console.WriteLine(it.CurrentItem().Nome);
            }
        }

        static void Memento_Exemplo1()
        {
            var texto = new Texto();
            texto.EscreverTexto("Primeira linha do texto\n");
            texto.EscreverTexto("Segunda linha do texto\n");
            texto.EscreverTexto("Terceira linha do texto\n");
            texto.MostrarTexto();
            texto.DesfazerEscrita();
            texto.MostrarTexto();
            texto.DesfazerEscrita();
            texto.MostrarTexto();
            texto.DesfazerEscrita();
            texto.MostrarTexto();
            texto.DesfazerEscrita();
            texto.MostrarTexto();
        }

        static void Memento_Exemplo2()
        {
            var o = new Originator
            {
                State = "On"
            };

            var c = new Caretaker
            {
                Memento = o.CreateMemento()
            };

            o.State = "Off";

            o.SetMemento(c.Memento);
        }

        static void State()
        {
            var conta = new Conta(1000);

            conta.Deposito(2500);
            conta.Saque(500);
            conta.Deposito(5000);
            conta.Saque(4500);
            conta.Saque(200);
            conta.Saque(3350);
            conta.Saque(1000);
        }

        static void Visitor_Exemplo1()
        {
            var store = new List<IStore>();
            store.Add(new Car() { CarName = "A1", Price = 200M, CarType = "Mercedes" });
            store.Add(new Car() { CarName = "A2", Price = 100M, CarType = "Normal" });

            store.Add(new Bike() { BikeName = "B1", Price = 50M, BikeType = "Bullet" });
            store.Add(new Bike() { BikeName = "B2", Price = 30M, BikeType = "Normal" });

            store.Add(new Moto() { MotoName = "C1", Price = 110M, MotoType = "Honda" });
            store.Add(new Moto() { MotoName = "C2", Price = 95M, MotoType = "Normal" });

            var priceVisitor = new PriceVisitor();
            foreach (var element in store)
            {
                element.Visit(priceVisitor);
            }

            Console.WriteLine();

            var weightVisitor = new WeightVisitor();
            foreach (var element in store)
            {
                element.Visit(weightVisitor);
            }
        }

        static void TemplateMethod()
        {
            var padeiro = new Padeiro();
            padeiro.FazerBolo(EBolo.TipoBolo.Chocolate);

            var confeiteiro = new Confeiteiro();
            confeiteiro.FazerBolo(EBolo.TipoBolo.Morango);
        }
    }
}