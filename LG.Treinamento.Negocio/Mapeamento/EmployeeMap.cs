using FluentNHibernate.Mapping;
using LG.Treinamento.Negocio.Models;

namespace LG.Prateleira.UI.Windows.Mapeamento
{
    class FuncionarioMap : ClassMap<Funcionario>
    {
        FuncionarioMap()
        {
            Id(x => x.Id).GeneratedBy.Increment();
            Map(x => x.Nome);
            Map(x => x.SobreNome);
        }
    }
}
