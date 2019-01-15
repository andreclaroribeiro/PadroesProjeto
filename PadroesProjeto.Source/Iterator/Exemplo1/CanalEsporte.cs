using System.Collections.Generic;

namespace PadroesProjeto.Source.Iterator
{
    public class CanalEsporte : IAgregadoCanal
    {
        private List<Canal> _canais;

        public CanalEsporte()
        {
            _canais = new List<Canal>
            {
                new Canal("Esporte ao vivo"),
                new Canal("Basquete 2011"),
                new Canal("Campeonato Italiano"),
                new Canal("Campeonato Espanhol"),
                new Canal("Campeonato Brasileiro")
            };
        }

        public IIterador CriarIterador()
        {
            return new IteradorListaCanal(_canais);
        }
    }
}