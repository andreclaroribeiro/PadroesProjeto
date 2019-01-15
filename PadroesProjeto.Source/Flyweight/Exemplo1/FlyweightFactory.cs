using System.Collections.Generic;

namespace PadroesProjeto.Source.Flyweight
{
    public class FlyweightFactory
    {
        private List<SpriteFlyweight> _flyweights;

        public FlyweightFactory()
        {
            _flyweights = new List<SpriteFlyweight>
            {
                new Sprite("jogador.png"),
                new Sprite("inimigo1.png"),
                new Sprite("inimigo2.png"),
                new Sprite("inimigo3.png"),
                new Sprite("cenario1.png"),
                new Sprite("cenario2.png")
            };
        }

        public SpriteFlyweight GetFlyweight(SpritesEnum spritesEnum)
        {
            return _flyweights[(int)spritesEnum];
        }
    }

    public enum SpritesEnum
    {
        Jogador = 0,
        Inimigo1 = 1,
        Inimigo2 = 2,
        Inimigo3 = 3,
        Cenario1 = 4,
        Cenario2 = 5
    }
}
