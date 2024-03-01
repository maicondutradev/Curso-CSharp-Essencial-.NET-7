// Cria uma instância da classe Aluno chamada 'aluno'
Aluno aluno = new Aluno();

// Define o atributo 'Nome' da instância 'aluno' como "Maicon"
aluno.Nome = "Maicon";

// Define o atributo 'Curso' da instância 'aluno' como "Engenharia de Software"
aluno.Curso = "Engenharia de Software";

// Imprime a saudação da instância 'aluno' usando o método 'Saudacao' da classe 'Aluno'
Console.WriteLine(aluno.Saudacao());
// Classe base 'Pessoa'
class Pessoa
{
    // Propriedade 'Nome' com getter e setter
    public string? Nome { get; set; }

    // Método que retorna uma saudação utilizando o nome da pessoa
    public string Saudacao() => $"Oi, Eu sou o(a) {Nome}";
}

// Classe derivada 'Aluno' que herda de 'Pessoa'
class Aluno : Pessoa
{
    // Propriedade 'Curso' com getter e setter
    public string? Curso { get; set; }

    // Método que retorna uma saudação específica para um aluno, incluindo o nome e o curso
    // Aviso: Este método está ocultando o método Saudacao da classe base Pessoa
    // É intencional e usa a palavra-chave 'new' para indicar isso.
    public new string Saudacao() => $"Oi, Eu sou o(a) {Nome} do curso de : {Curso}";
}