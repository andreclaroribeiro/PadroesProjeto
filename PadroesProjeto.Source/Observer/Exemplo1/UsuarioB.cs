using System;

namespace PadroesProjeto.Source.Observer
{
    public class UsuarioB
    {
        public void Assinar(ControladorEmail controlador)
        {
            controlador.ProcessarEmail += ProcessarEmail;
        }
        public void ProcessarEmail()
        {
            Console.WriteLine("Email Recebido pelo usuário B");
        }
        public void CancelarAssinatura(ControladorEmail controlador)
        {
            controlador.ProcessarEmail -= ProcessarEmail;
        }
    }
}