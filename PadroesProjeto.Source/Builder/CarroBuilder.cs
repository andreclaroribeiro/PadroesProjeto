namespace PadroesProjeto.Source.Builder
{
    public abstract class CarroBuilder
    {
        protected CarroProduct _carro;

        public CarroBuilder()
        {
            _carro = new CarroProduct();
        }

        public abstract void BuildPreco();

        public abstract void BuildMotor();

        public abstract void BuildAnoFabricacao();

        public abstract void BuildModelo();

        public abstract void BuildMontadora();

        public CarroProduct GetCarro()
        {
            return _carro;
        }
    }
}