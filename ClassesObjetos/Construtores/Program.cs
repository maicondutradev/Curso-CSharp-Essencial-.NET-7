using System.Linq.Expressions;

// Criando uma instância da classe Aluno
Aluno aluno = new Aluno("Maicon", 23, "Masculino", "Aprovado");

// Verificando se o atributo Nome é nulo e imprimindo "Null" se for verdadeiro, caso contrário, imprime o valor de Nome
Console.WriteLine(aluno.Nome == null ? "Null" : aluno.Nome);

// Verificando se o atributo Idade é igual a 0 e imprimindo "zero" se for verdadeiro, caso contrário, imprime o valor de Idade
Console.WriteLine(aluno.Idade == 0 ? "zero" : aluno.Idade);

// Verificando se o atributo Sexo é nulo e imprimindo "Null" se for verdadeiro, caso contrário, imprime o valor de Sexo
Console.WriteLine(aluno.Sexo == null ? "Null" : aluno.Sexo);

// Verificando se o atributo Aprovado é nulo e imprimindo "Null" se for verdadeiro, caso contrário, imprime o valor de Aprovado
Console.WriteLine(aluno.Aprovado == null ? "Null" : aluno.Aprovado);

// Definindo a classe Aluno com atributos Nome, Idade, Sexo e Aprovado
public class Aluno
{

    public Aluno(string nome)
    {
        Nome = nome;
    }

    // Construtor da classe Aluno que recebe parâmetros para inicializar os atributos
    public Aluno(string nome, int idade, string sexo, string aprovado) : this(nome)
    {
        Idade = idade;
        Sexo = sexo;
        Aprovado = aprovado;
    }

    // Atributo Nome da classe Aluno
    public string? Nome;

    // Atributo Idade da classe Aluno
    public int Idade;

    // Atributo Sexo da classe Aluno
    public string? Sexo;

    // Atributo Aprovado da classe Aluno
    public string? Aprovado;
}
