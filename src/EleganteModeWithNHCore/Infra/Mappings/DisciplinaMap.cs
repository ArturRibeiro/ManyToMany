using EleganteModeWithNHCore.Domain;

namespace EleganteModeWithNHCore.Infra.Mappings;

internal class DisciplinaMap : ClassMap<Disciplina>
{
    public DisciplinaMap()
    {
        Table(nameof(Disciplina));
        Id(x => x.DisciplinaId, "Id");
        Map(x => x.Nome);
        
        HasManyToMany(x => x.Alunos)
            .Cascade.All()
            .Table("AlunoDisciplina");
    }
}