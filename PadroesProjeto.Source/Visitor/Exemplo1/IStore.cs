namespace PadroesProjeto.Source.Visitor
{
    public interface IStore
    {
        void Visit(IVisitor visitor);
    }
}