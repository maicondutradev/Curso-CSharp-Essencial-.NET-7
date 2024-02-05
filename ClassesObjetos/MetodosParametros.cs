using System.Globalization;


public class Aluno
{
    public string? Nome;
    public int Idade;
    public string? Sexo;
    public string? Aprovado;
}

public class Curso
{
    public void Resultado(Aluno aluno)
    {
        Console.WriteLine($"O aluno {aluno.Nome}, sexo {aluno.Sexo} com {aluno.Idade} anos");
        if (aluno.Aprovado == "s")
        {
            Console.WriteLine("Foi aprovado!");
        }
        else
        {
            Console.WriteLine("Foi reprovado!");
        }
    }
}