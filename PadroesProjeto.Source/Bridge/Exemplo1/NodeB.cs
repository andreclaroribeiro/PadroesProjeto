using System;

namespace PadroesProjeto.Source.Bridge
{
    public class NodeB : INode
    {
        public void Reach()
        {
            Console.WriteLine("Remontado para o nó B");
        }
    }
}