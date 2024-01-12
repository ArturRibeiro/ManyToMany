using EleganteModeWithNHCore.Domain;

namespace EleganteModeWithNHCore.Infra.Mappings;

internal class AlunoMap : ClassMap<Aluno>
{
    public AlunoMap()
    {
        Table("Aluno");
        Id(x => x.AlunoId, "id");
        Map(x => x.Nome);
        
        HasManyToMany(x => x.Disciplinas)
            .Cascade.All()
            .Inverse()
            .Table("AlunoDisciplina");
    }
}