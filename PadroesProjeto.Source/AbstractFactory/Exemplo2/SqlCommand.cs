﻿using System;

namespace PadroesProjeto.Source.AbstractFactory
{
    public class SqlCommand : DbCommand
    {
        public override void Execute()
        {
            Console.WriteLine("Executando o comando do sql.....");
        }
    }
}