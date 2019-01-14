using System;

namespace PadroesProjeto.Source.Bridge
{
    public class NodeA : INode
    {
        public void Reach()
        {
            Console.WriteLine("Remontado para o nó A");
        }
    }
}