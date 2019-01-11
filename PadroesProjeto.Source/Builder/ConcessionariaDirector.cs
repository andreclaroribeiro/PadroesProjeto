namespace PadroesProjeto.Source.Builder
{
    public class ConcessionariaDirector
    {
        protected CarroBuilder _montadora;

        public ConcessionariaDirector(CarroBuilder montadora)
        {
            _montadora = montadora;
        }

        public void construirCarro()
        {
            _montadora.BuildPreco();
            _montadora.BuildAnoFabricacao();
            _montadora.BuildMotor();
            _montadora.BuildModelo();
            _montadora.BuildMontadora();
        }

        public CarroProduct GetCarro()
        {
            return _montadora.GetCarro();
        }
    }
}