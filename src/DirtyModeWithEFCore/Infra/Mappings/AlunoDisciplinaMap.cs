using DirtyModeWithEFCore.Domain;

namespace DirtyModeWithEFCore.Infra.Mappings;

internal class AlunoDisciplinaMap : IEntityTypeConfiguration<AlunoDisciplina>
{
    public void Configure(EntityTypeBuilder<AlunoDisciplina> builder)
    {
        builder.ToTable("AlunoDisciplina");
        builder.HasKey(t => new { t.DisciplinaId, t.AlunoId });
        builder.Property(i => i.DisciplinaId);
        builder.Property(p => p.DisciplinaId);
    }
}