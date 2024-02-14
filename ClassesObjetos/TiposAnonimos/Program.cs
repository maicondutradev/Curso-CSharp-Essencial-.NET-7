//Tipo Anônimo
using System.Data.Common;

var aluno = new
{
    Nome = "Maria",
    Idade = 43
};
Console.WriteLine($"{aluno.Nome} - {aluno.Idade}");

//Tipo anônimo com uma propriedade de outro tipo anônimo
var aluno1 = new
{
    Id = 1,
    Nome = "Jairo",
    Email = "jairo@gmail.com",
    Endereco = new { Id = 1, Cidade = "Santos", Pais = "Brasil" }
};
Console.WriteLine(aluno1.Endereco.Cidade);

//Podemos criar um array de tipos anônimos
var alunos2 = new[]
{
    new {Id = 1, Nome = "Maria", Email = "maria@gmail.com"},
    new {Id = 2, Nome = "Sonia", Email = "sonia@gmail.com"},
    new {Id = 3, Nome = "Bruno", Email = "bruno@gmail.com"}
};
Console.WriteLine(alunos2[0].Nome);
Console.WriteLine(alunos2[2].Email);