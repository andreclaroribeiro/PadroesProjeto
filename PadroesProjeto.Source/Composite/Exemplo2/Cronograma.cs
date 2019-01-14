using System;
using System.Text;

namespace PadroesProjeto.Source.Composite
{
    public abstract class Cronograma
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        private ItemTrabalho _itemTrabalho;

        public void SetItemTrabalho(ItemTrabalho itemTrabalho)
        {
            _itemTrabalho = itemTrabalho;
        }

        public ItemTrabalho GetItemTrabalho()
        {
            return _itemTrabalho;
        }

        private StringBuilder _node = new StringBuilder();

        private void ShowEap(ItemTrabalho itemTrabalho)
        {
            _node.Append("+");

            Console.WriteLine(_node.ToString() + " " + itemTrabalho.Nome);

            if (itemTrabalho.GetItemTrabalho() != null)
            {
                ShowEap(itemTrabalho.GetItemTrabalho());
            }

            //_node.SetLength(0);
        }

        public void PrintEap()
        {
            Console.WriteLine("\n" + this.Nome);
            Console.WriteLine(" ******* Custo Total: R$ " + _itemTrabalho.GetTotal().ToString());
            this.ShowEap(_itemTrabalho);
        }
    }
}