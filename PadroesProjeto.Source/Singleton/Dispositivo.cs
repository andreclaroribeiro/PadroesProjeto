using System;

namespace PadroesProjeto.Source.Singleton
{
    public class Dispositivo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }

        private static Dispositivo instance = new Dispositivo();

        public void Ligar()
        {
            Console.WriteLine("Equipamento ligado.");
        }

        public void Desligar()
        {
            Console.WriteLine("Equipamento desligado.");
        }

        public static Dispositivo GetInstance()
        {
            return instance ?? (instance = new Dispositivo());
        }

        public override string ToString()
        {
            return $"Marca e Modelo {Marca} - {Modelo}";
        }

        private Dispositivo() { }
    }
}