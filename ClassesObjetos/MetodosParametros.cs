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
    public void Resultado(string nome, int idade, string sexo, string aprovado)
    {
        Console.WriteLine($"O aluno {nome}, sexo {sexo} com {idade} anos");
        if (aprovado == "S")
        {
            Console.WriteLine("Foi aprovado!");
        }
        else
        {
            Console.WriteLine("Foi reprovado!");
        }
    }
}