namespace DirtyModeWithEFCore.Domain;

public class Aluno
{
    public virtual int AlunoId { get; set; }
    public virtual string Nome { get; set; }
    public virtual IList<AlunoDisciplina> Disciplinas { get; set; }
}


