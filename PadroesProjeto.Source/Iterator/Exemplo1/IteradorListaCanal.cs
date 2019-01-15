using System.Collections.Generic;

namespace PadroesProjeto.Source.Iterator
{
    public class IteradorListaCanal : IIterador
    {
        private List<Canal> _lista;
        private int _contador;

        public IteradorListaCanal(List<Canal> lista)
        {
            _lista = lista;
            _contador = 0;
        }

        public Canal CurrentItem()
        {
            if (IsDone())
            {
                _contador = _lista.Count - 1;
            }
            else if (_contador < 0)
            {
                _contador = 0;
            }
            return _lista[_contador];
        }

        public void First()
        {
            _contador = 0;
        }

        public bool IsDone()
        {
            return _contador == _lista.Count;
        }

        public void Next()
        {
            _contador++;
        }
    }
}