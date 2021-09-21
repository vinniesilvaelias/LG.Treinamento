using FluentNHibernate.Mapping;
using LG.Treinamento.Negocio.Models;

namespace LG.Prateleira.UI.Windows.Mapeamento
{
    class ProdutoMap : ClassMap<Produto>
    {
        ProdutoMap()
        {
            Id(x => x.Id).GeneratedBy.Increment();
            Map(x => x.Nome);
            Map(x => x.Preco);
            Map(x => x.Corredor);
            Map(x => x.Prateleira);
        }
    }
}
