using System;

namespace PadroesProjeto.Source.Flyweight
{
    public class Sprite : SpriteFlyweight
    {
        protected Imagem _imagem;

        public Sprite(string nomeImagem)
        {
            _imagem = new Imagem(nomeImagem);
        }

        public override void DesenharImagem(Ponto ponto)
        {
            _imagem.DesenharImagem();

            Console.WriteLine($"No ponto ({ponto.X}, {ponto.Y})!");
            Console.WriteLine();
        }
    }
}