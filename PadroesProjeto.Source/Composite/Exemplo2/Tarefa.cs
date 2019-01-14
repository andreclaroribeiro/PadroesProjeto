using System;

namespace PadroesProjeto.Source.Composite
{
    public class Tarefa : ItemTrabalho
    {
        public decimal Preco { get; private set; }

        public Tarefa(int id, string nome, decimal preco)
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

        private decimal CalcularTotal(ItemTrabalho tarefa)
        {
            var total = tarefa.GetPreco();
            if (tarefa.GetItemTrabalho() != null)
            {
                total = total += CalcularTotal(tarefa.GetItemTrabalho());
            }
            return total;
        }

        public void SetItemTrabalho(ItemTrabalho itemTrabalho)
        {
            try
            {
                if (!(itemTrabalho is Tarefa))
                    throw new Exception("Somente tarefas serão aceitas");

                base.SetItemTrabalho(itemTrabalho);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}