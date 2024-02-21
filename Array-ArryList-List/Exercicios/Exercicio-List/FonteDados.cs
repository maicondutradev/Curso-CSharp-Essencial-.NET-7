// Classe que fornece dados fictícios de alunos
public class FonteDados
{
    // Método estático que retorna uma lista de objetos Aluno com dados predefinidos
    public static List<Aluno> GetAlunos()
    {
        List<Aluno> alunos = new List<Aluno>()
        {
            // Inicializa uma lista de alunos com nomes e notas predefinidos
            new Aluno (){Nome = "Maria", Nota = 8.75},
            new Aluno (){Nome = "Manuel", Nota = 6.95},
            new Aluno (){Nome = "Amanda", Nota = 7.25},
            new Aluno (){Nome = "Carlos", Nota = 6.55},
            new Aluno (){Nome = "Jaime", Nota = 8.50},
            new Aluno (){Nome = "Debora", Nota = 5.95},
            new Aluno (){Nome = "Alicia", Nota = 9.25},
            new Aluno (){Nome = "Sandra", Nota = 5.55},
            new Aluno (){Nome = "Marta", Nota = 7.85},
            new Aluno (){Nome = "Sueli", Nota = 9.15},
        };
        // Retorna a lista de alunos
        return alunos;
    }
}