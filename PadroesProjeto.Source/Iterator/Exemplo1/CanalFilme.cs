namespace PadroesProjeto.Source.Iterator
{
    public class CanalFilme : IAgregadoCanal
    {
        private Canal[] _canais;

        public CanalFilme()
        {
            _canais = new Canal[4];
            _canais[0] = new Canal("Cinemax");
            _canais[1] = new Canal("HBO");
            _canais[2] = new Canal("FOX");
            _canais[3] = new Canal("Sony");
        }
        public IIterador CriarIterador()
        {
            return new IteradorMatrizCanal(_canais);
        }

    }
}