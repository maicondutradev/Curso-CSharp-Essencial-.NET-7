// Imprime um cabeçalho indicando que a seção trata de herança
Console.WriteLine("### Herança ###\n");

// Cria uma instância da classe Funcionario
Funcionario funcionario = new Funcionario();
// Define algumas propriedades do funcionário
funcionario.Nome = "Mirela";
funcionario.Email = "mirela@gmail.com";
funcionario.Empresa = "Oewns Ilinois";
funcionario.Salario = 1200;

// Imprime informações sobre o funcionário
Console.WriteLine("Funcionario");
Console.WriteLine(funcionario.Empresa);
Console.WriteLine(funcionario.Salario);
// Chama o método Identificar da classe Pessoa para imprimir Nome e Email
funcionario.Identificar();

// Cria uma instância da classe Aluno
Aluno aluno = new Aluno();
// Define algumas propriedades do aluno
aluno.Nome = "Maicon";
aluno.Email = "maicon@gmail.com";
aluno.Curso = "Engenharia de Software";
aluno.Nota = 10;

// Imprime informações sobre o aluno
Console.WriteLine("Aluno");
Console.WriteLine(aluno.Curso);
Console.WriteLine(aluno.Nota);
// Chama o método Identificar da classe Pessoa para imprimir Nome e Email
aluno.Identificar();

// Definição da classe base Pessoa
public class Pessoa
{
    public string? Nome { get; set; }
    public string? Email { get; set; }

    // Método para imprimir Nome e Email
    public void Identificar()
    {
        Console.WriteLine($"{Nome} - {Email}");
    }
}

// Definição da classe Funcionario que herda da classe Pessoa
public class Funcionario : Pessoa
{
    public string? Empresa { get; set; }
    public decimal Salario { get; set; }
}

// Definição da classe Aluno que herda da classe Pessoa
public class Aluno : Pessoa
{
    public string? Curso { get; set; }
    public int Nota { get; set; }
}
