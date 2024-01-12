using EleganteModeWithEFCore.Domain;

namespace EleganteModeWithEFCore.Infra.Mappings;

internal class AlunoMap : IEntityTypeConfiguration<Aluno>
{
    public void Configure(EntityTypeBuilder<Aluno> builder)
    {
        builder.ToTable("Aluno");
        builder.HasKey(p => p.AlunoId);
        builder.Property(i => i.AlunoId).ValueGeneratedOnAdd();
        builder.Property(p => p.Nome);
        builder.HasMany(s => s.Disciplinas)
            .WithMany(c => c.Alunos)
            .UsingEntity<Dictionary<string, object>>(
                right => right
                    .HasOne<Disciplina>()
                    .WithMany()
                    .HasForeignKey("DisciplinaId"),
                left => left
                    .HasOne<Aluno>()
                    .WithMany()
                    .HasForeignKey("AlunoId"),
                join => join
                    .ToTable("AlunoDisciplinas")
                    .HasKey("AlunoId", "DisciplinaId")
            );
    }
}