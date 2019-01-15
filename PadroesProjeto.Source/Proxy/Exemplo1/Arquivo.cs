using System;

namespace PadroesProjeto.Source.Proxy
{
    public class Arquivo : IArquivo
    {
        private string _nomeArquivo;

        public Arquivo(string nomeArquivo)
        {
            _nomeArquivo = nomeArquivo;
            LoadArquivo();
        }

        private void LoadArquivo()
        {
            Console.WriteLine("Carregando: " + _nomeArquivo);
        }

        public void GetArquivo()
        {
            Console.WriteLine(_nomeArquivo);
        }
    }
}