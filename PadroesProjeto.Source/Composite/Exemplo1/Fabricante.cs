using System.Collections;
using System.Collections.Generic;

namespace PadroesProjeto.Source.Composite
{
    public class Fabricante : ICarro, IEnumerable
    {
        private IList<ICarro> carrosOrganizados = new List<ICarro>();
        public string Nome { get; set; }
        public string Modelo { get; set; }

        public Fabricante(string param)
        {
            this.Nome = param;
        }

        public void AcrescentaNaLista(ICarro Modelo)
        {
            carrosOrganizados.Add(Modelo);
        }

        public ICarro Recupera(int _paramIndex)
        {
            return carrosOrganizados[_paramIndex];
        }

        public IEnumerator RecuperaEnumerator()
        {
            foreach (ICarro item in carrosOrganizados)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return RecuperaEnumerator();
        }
    }
}