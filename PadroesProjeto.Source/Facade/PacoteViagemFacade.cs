using System;

namespace PadroesProjeto.Source.Facade
{
    public class PacoteViagemFacade
    {
        public void Adquirir()
        {
            Console.WriteLine("Iniciando aquisição do pacote de viagem.");
            Console.WriteLine();

            var ciaAereaService = new CiaAereaService();
            ciaAereaService.Comprar();

            var hotelService = new HotelService();
            hotelService.Reservar();

            var locadoraCarroService = new LocadoraCarroService();
            locadoraCarroService.Alugar();

            Console.WriteLine();
            Console.WriteLine("Pacote de viagem adquirido com sucesso.");
        }
    }
}