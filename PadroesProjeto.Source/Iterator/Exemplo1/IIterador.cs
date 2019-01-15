namespace PadroesProjeto.Source.Iterator
{
    public interface IIterador
    {
        void First();

        void Next();

        bool IsDone();

        Canal CurrentItem();
    }
}