Dictionary<int, int> dic1 = new Dictionary<int, int>();
dic1.Add(1, 100);
dic1.Add(2, 200);
dic1.Add(3, 300);
dic1.Add(4, 400);


var dic2 = new Dictionary<int, int>()
{
    {1,100},
    {2,200},
    {5,500},
    {4,400}
};

Console.WriteLine("\nIncluir elemento com chave(3) duplicada");
try
{
    dic2.Add(3, 300);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.WriteLine("\nUsando o método TryAdd para a chave 3");
var resultado = dic2.TryAdd(3, 300);
Console.WriteLine($"\nElemento foi incluido? {resultado}");

if (!dic2.ContainsKey(5))
{
    Console.WriteLine("\nIncluindo o elemento com chave 5 e valor 500");
    dic2.Add(5, 500);
}

if (dic2.ContainsValue(500))
{
    Console.WriteLine("\nUsando ContainsValue");
    Console.WriteLine("\nO valor existe no dicionário 2");
}

Console.WriteLine($"\nO dicionario 2 tem os seguintes valores");
foreach (var item in dic2)
{
    Console.WriteLine($"{item.Key} {item.Value}");
}

Console.WriteLine("\nOrdenando os elementos do dicionario(SortedDictionary/LINQ)");

//var dic2Ordenado = dic2.OrderBy(x => x.Key);
var dic2Ordenado = new SortedDictionary<int, int>(dic2);

foreach (var item in dic2Ordenado)
{
    Console.WriteLine($"{item.Key} {item.Value}");
}