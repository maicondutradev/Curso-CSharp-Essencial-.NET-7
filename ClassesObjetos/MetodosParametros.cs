using System.Globalization;


public class Aluno
{
    public string? Nome;
    public int Idade;
    public string? Sexo;
    public string? Aprovado;

    public void Consultar()
    {
        Aluno aluno = new Aluno();

        Console.WriteLine("Nome: ");
        aluno.Nome = Console.ReadLine();

        Console.WriteLine("Idade: ");
        aluno.Idade = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Sexo: ");
        aluno.Sexo = Console.ReadLine();

        Console.WriteLine("Aprovado (S)im (N)ão: ");
        aluno.Aprovado = Console.ReadLine().ToLower();

        Curso curso = new Curso();
        curso.Resultado(aluno);
    }
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