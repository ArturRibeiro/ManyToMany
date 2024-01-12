using EleganteModeWithEFCore.Domain;

namespace EleganteModeWithEFCore.Infra.Mappings;

internal class DisciplinaMap : IEntityTypeConfiguration<Disciplina>
{
    public void Configure(EntityTypeBuilder<Disciplina> builder)
    {
        builder.ToTable("Disciplina");
        builder.HasKey(p => p.DisciplinaId);
        builder.Property(i => i.DisciplinaId).ValueGeneratedOnAdd();
        builder.Property(p => p.Nome);
        
        builder.HasMany(s => s.Alunos)
            .WithMany(c => c.Disciplinas)
            .UsingEntity<Dictionary<string, object>>(
                right => right
                    .HasOne<Aluno>()
                    .WithMany()
                    .HasForeignKey("AlunoId"),
                left => left
                    .HasOne<Disciplina>()
                    .WithMany()
                    .HasForeignKey("DisciplinaId"),
                join => join
                    .ToTable("AlunoDisciplinas")
                    .HasKey("DisciplinaId", "AlunoId")
            );
    }
}