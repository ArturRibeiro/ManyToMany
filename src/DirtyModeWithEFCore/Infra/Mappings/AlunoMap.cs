using DirtyModeWithEFCore.Domain;

namespace DirtyModeWithEFCore.Infra.Mappings;

internal class AlunoMap : IEntityTypeConfiguration<Aluno>
{
    public void Configure(EntityTypeBuilder<Aluno> builder)
    {
        builder.ToTable("Aluno");
        builder.HasKey(p => p.AlunoId);
        builder.Property(i => i.AlunoId).ValueGeneratedOnAdd();
        builder.Property(p => p.Nome);
        builder.HasMany(o => o.Disciplinas);
    }
}