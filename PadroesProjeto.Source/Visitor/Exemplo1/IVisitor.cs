namespace PadroesProjeto.Source.Visitor
{
    public interface IVisitor
    {
        void Accept(Car car);
        void Accept(Bike bike);
        void Accept(Moto bike);
    }
}