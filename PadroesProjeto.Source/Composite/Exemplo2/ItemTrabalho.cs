namespace PadroesProjeto.Source.Composite
{
    public abstract class ItemTrabalho
    {
        public int Id { get; set; }
        public bool Ativo { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        private ItemTrabalho _itemTrabalho;
        public void SetItemTrabalho(ItemTrabalho itemTrabalho)
        {
            _itemTrabalho = itemTrabalho;
        }
        public ItemTrabalho GetItemTrabalho()
        {
            return _itemTrabalho;
        }

        abstract public decimal GetPreco();
        abstract public decimal GetTotal();
    }
}