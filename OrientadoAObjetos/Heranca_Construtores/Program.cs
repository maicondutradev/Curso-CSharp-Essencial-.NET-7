// Criação de uma instância da classe Aluno sem parâmetros
Aluno aluno1 = new Aluno();

// Criação de uma instância da classe Aluno com o parâmetro "José"
Aluno aluno2 = new Aluno("José");

// Definição da classe base Pessoa
class Pessoa
{
    // Construtor padrão da classe Pessoa
    public Pessoa()
    {
        Console.WriteLine("Construtor da classe Pessoa");
    }

    // Construtor da classe Pessoa com parâmetro nome
    public Pessoa(string nome)
    {
        Console.WriteLine("Construtor da classe Pessoa com parâmetro");
    }
}

// Definição da classe derivada Aluno, que herda de Pessoa
class Aluno : Pessoa
{
    // Construtor padrão da classe Aluno, chamando o construtor padrão da classe base Pessoa
    public Aluno() : base()
    {
        Console.WriteLine("Construtor da classe Aluno");
    }

    // Construtor da classe Aluno com parâmetro nome, chamando o construtor da classe base Pessoa com o mesmo parâmetro
    public Aluno(string nome) : base(nome)
    {
        Console.WriteLine("Construtor da classe Aluno com parâmetro");
    }
}
