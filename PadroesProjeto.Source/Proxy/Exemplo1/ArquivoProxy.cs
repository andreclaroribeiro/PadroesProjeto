namespace PadroesProjeto.Source.Proxy
{
    public class ArquivoProxy : IArquivo
    {
        private string _nomeArquivo;
        private Arquivo _arquivo;

        public ArquivoProxy(string nomeArquivo)
        {
            _nomeArquivo = nomeArquivo;
            GetArquivo();
        }

        public void GetArquivo()
        {
            _arquivo = new Arquivo(_nomeArquivo);
            _arquivo.GetArquivo();
        }
    }
}