using System;

namespace PadroesProjeto.Source.Builder
{
    public class VolksBuilder : CarroBuilder
    {
        public override void BuildAnoFabricacao()
        {
            // Operação complexa.
            _carro.AnoFabricacao = DateTime.Now.Year;
        }

        public override void BuildMotor()
        {
            // Operação complexa.
            _carro.Motor = "Motor do volks";
        }

        public override void BuildModelo()
        {
            // Operação complexa.
            _carro.Modelo = "Modelo do volks";
        }

        public override void BuildMontadora()
        {
            // Operação complexa.
            _carro.Montadora = "Volks";
        }

        public override void BuildPreco()
        {
            // Operação complexa.
            _carro.Preco = 78200.00;
        }
    }
}