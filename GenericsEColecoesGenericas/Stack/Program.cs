//O ultimo a entrar é o primeiro a sair
Stack<int> numeros = new Stack<int>();
numeros.Push(1);
numeros.Push(2);
numeros.Push(2);
numeros.Push(4);
numeros.Push(5);


Console.WriteLine($"A pilha original contém {numeros.Count} itens");

ExibirPilha(numeros);

Console.WriteLine($"\nItem obtido da pilha (Peek) : {numeros.Peek()}");

Console.WriteLine($"\nItem removido da pilha (Pop) : {numeros.Pop()}");

ExibirPilha(numeros);

Console.WriteLine($"");

static void ExibirPilha<T>(IEnumerable<T> numeros)
{
    Console.WriteLine();
    foreach (var numero in numeros)
    {
        Console.WriteLine(numero);
    }
}
