namespace EleganteModeWithNHCore.Domain;

public class Disciplina
{
    public virtual int DisciplinaId { get; set; }
    public virtual string Nome { get; set; }
    public virtual IList<Aluno> Alunos { get; set; }
}