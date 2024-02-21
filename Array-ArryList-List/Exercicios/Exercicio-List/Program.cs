using System.Runtime.CompilerServices;

// Obtém a lista de alunos da classe FonteDados
List<Aluno> alunos = FonteDados.GetAlunos();

ExibirAlunos(alunos);

Aluno bia = new Aluno() { Nome = "Bia", Nota = 7.75 };
Aluno Mario = new Aluno() { Nome = "Mario", Nota = 8.95 };
alunos.Add(bia);
alunos.Add(Mario);

ExibirAlunos(alunos);

var aluno1 = alunos.Find(n => n.Nome.Equals("Amanda"));
alunos.Remove(aluno1);

ExibirAlunos(alunos);

//alunos.Sort();
var listaOrdenada = alunos.OrderBy(n => n.Nome).ToList();

ExibirAlunos(listaOrdenada);

var alunosNotaOito = alunos.FindAll(n => n.Nota >= 8);
Console.WriteLine("\nAlunos com nota maior que 8");
foreach (var item in alunosNotaOito)
{
    Console.WriteLine($"{item.Nome} \t{item.Nota}");
}

//Método para exibir a lusta de alunos com nome e nota, a média aritmética das notas e a quantiade de alunos na lista
static void ExibirAlunos(List<Aluno> alunos)
{
    // Imprime cabeçalho para a lista de alunos
    Console.WriteLine("\nRelação de alunos\n");
    Console.WriteLine("\nNome \tNota");

    var somaNotas = 0.0;

    // Itera sobre cada aluno na lista e imprime seu nome e nota
    foreach (var item in alunos)
    {
        Console.WriteLine($"{item.Nome}\t{item.Nota}");
        somaNotas += item.Nota;
    }

    var mediaNotas = somaNotas / alunos.Count;

    Console.WriteLine($"\nMedia das notas: {Math.Round(mediaNotas, 2)}");
    Console.WriteLine($"\nTotal de alunos: {alunos.Count}");
}


Console.ReadKey();