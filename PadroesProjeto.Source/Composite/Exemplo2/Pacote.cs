namespace PadroesProjeto.Source.Composite
{
    public class Pacote : ItemTrabalho
    {
        public decimal Preco { get; private set; }

        public Pacote(int id, string nome, decimal preco)
        {
            Id = id;
            Nome = nome;
            Preco = preco;
        }

        public override decimal GetPreco()
        {
            return Preco;
        }

        public override decimal GetTotal()
        {
            return CalcularTotal(this);
        }

        private decimal CalcularTotal(ItemTrabalho itemTrabalho)
        {
            var total = itemTrabalho.GetPreco();
            if (itemTrabalho.GetItemTrabalho() != null)
                total = total += CalcularTotal(itemTrabalho.GetItemTrabalho());
            return total;
        }
    }
}