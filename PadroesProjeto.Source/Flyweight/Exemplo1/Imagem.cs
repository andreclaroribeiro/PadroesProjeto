using System;

namespace PadroesProjeto.Source.Flyweight
{
    public class Imagem
    {
        public string Nome { get; private set; }

        public Imagem(string nome)
        {
            Nome = nome;
        }

        public void DesenharImagem()
        {
            Console.WriteLine($"{Nome} desenhada!");
        }
    }
}