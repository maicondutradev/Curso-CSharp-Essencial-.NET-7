//Criação da coleção hashset com itens
//HashSet de int
var numeros = new HashSet<int> { 1, 2, 3, 4, 5 };

//HashSet de string
HashSet<string> frutas = new HashSet<string> { "Maça", "Pera", "Uva", "Melancia", "Jaca" };

//HashSet de int
HashSet<int> pares = new HashSet<int>();
for (int i = 0; i < 6; i++)
{
    pares.Add(i * 2);
}
foreach (var item in pares)
{
    Console.WriteLine(item);
}

//Construtor usando IEnumerable
var lista1 = new List<int> { 1, 2, 3, 4, 5 };
HashSet<int> conjunto = new HashSet<int>(lista1);

