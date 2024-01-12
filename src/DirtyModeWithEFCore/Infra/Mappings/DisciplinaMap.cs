using DirtyModeWithEFCore.Domain;

namespace DirtyModeWithEFCore.Infra.Mappings;

internal class DisciplinaMap : IEntityTypeConfiguration<Disciplina>
{
    public void Configure(EntityTypeBuilder<Disciplina> builder)
    {
        builder.ToTable("Disciplina");
        builder.HasKey(p => p.DisciplinaId);
        builder.Property(i => i.DisciplinaId).ValueGeneratedOnAdd();
        builder.Property(p => p.Nome);
        builder.HasMany(o => o.Alunos);
    }
}