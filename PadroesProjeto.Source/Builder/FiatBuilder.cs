using System;

namespace PadroesProjeto.Source.Builder
{
    public class FiatBuilder : CarroBuilder
    {
        public override void BuildAnoFabricacao()
        {
            // Operação complexa.
            _carro.AnoFabricacao = DateTime.Now.Year;
        }

        public override void BuildMotor()
        {
            // Operação complexa.
            _carro.Motor = "Motor do fiat";
        }

        public override void BuildModelo()
        {
            // Operação complexa.
            _carro.Modelo = "Modelo do fiat";
        }

        public override void BuildMontadora()
        {
            // Operação complexa.
            _carro.Montadora = "Fiat";
        }

        public override void BuildPreco()
        {
            // Operação complexa.
            _carro.Preco = 55600.00;
        }
    }
}