namespace PadroesProjeto.Source.Iterator
{
    public class IteradorMatrizCanal : IIterador
    {
        private Canal[] _lista;
        private int _contador;

        public IteradorMatrizCanal(Canal[] lista)
        {
            _lista = lista;
        }

        public Canal CurrentItem()
        {
            if (IsDone())
            {
                _contador = _lista.Length - 1;
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
            return _contador == _lista.Length;
        }

        public void Next()
        {
            _contador++;
        }
    }
}