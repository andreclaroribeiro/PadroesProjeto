namespace PadroesProjeto.Source.Visitor
{
    public class Moto : IStore
    {
        public string MotoName { get; set; }
        public decimal Price { get; set; }
        public string MotoType { get; set; }

        public void Visit(IVisitor visitor)
        {
            visitor.Accept(this);
        }
    }
}