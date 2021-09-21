using FluentNHibernate.Mapping;
using LG.Treinamento.Negocio.Models;

namespace LG.Prateleira.UI.Windows.Mapeamento
{
    class StoreMap : ClassMap<Empresa>
    {
        StoreMap()
        {
            Id(x => x.Id).GeneratedBy.Increment();
            Map(x => x.Nome);

            HasMany(x => x.Produtos)
                .Cascade.All()
                .KeyColumn("StoreId");
        }
    }
}
