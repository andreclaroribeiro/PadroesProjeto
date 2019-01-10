using System;

namespace PadroesProjeto.Source.AbstractFactory
{
    public class ButtonWeb : IButton
    {
        public void Criar()
        {
            Console.WriteLine("Botão Web criado!");
        }
    }
}