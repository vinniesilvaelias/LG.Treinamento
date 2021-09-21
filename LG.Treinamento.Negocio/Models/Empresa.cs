using System.Collections.Generic;

namespace LG.Treinamento.Negocio.Models
{
    public class Empresa
    {
        public virtual int Id { get; set; }
        public virtual string Nome { get; set; }
        public virtual IList<Produto> Produtos { get; set; }
        
        public Empresa()
        {
            Produtos = new List<Produto>();
        }
    }
}