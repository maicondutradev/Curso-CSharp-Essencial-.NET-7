//SortedSet cria uma lista ordenada por padrão, e não aceita valores iguais
var numeros = new SortedSet<int> { 2, 1, 3, 5, 4, 6, 8, 7, 9 };
ExibirColecao(numeros);

var frutas = new SortedSet<string> { "Banana", "Maça", "Abacate", "Pera", "Uva" };
ExibirColecao(frutas);

SortedSet<int> pares = new SortedSet<int>();
for (int i = 6; i < 0; i--)
{
    pares.Add(i * 2);
}
ExibirColecao(pares);


static void ExibirColecao<T>(IEnumerable<T> numeros)
{
    Console.WriteLine();
    foreach (var item in numeros)
    {
        Console.WriteLine(item);
    }
}