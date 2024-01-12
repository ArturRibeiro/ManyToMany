namespace DirtyModeWithEFCore.Domain;

public class AlunoDisciplina
{
    public Aluno Aluno { get; set; }
    public int AlunoId { get; set; }
    
    public Disciplina Disciplina { get; set; }
    public int DisciplinaId { get; set; }
}