Console.WriteLine("\n### Criando o SortedDictionary ###");

//SortedDictionary<int, string> brics = new SortedDictionary<int, string>();
//O SortedDictionary já cria um dicionario ordenado
var brics = new SortedDictionary<int, string>()
{
    {20, "Brasil"},
    {10, "China"},
    {40, "India"},
    {30, "URSS"},
};

Console.WriteLine("\nIncluindo o elemento de chave= 50 e valor= África do sul");

if (brics.ContainsKey(50))
{
    Console.WriteLine("Chave já existe!");
}
else
{
    brics.Add(50, "África do Sul");
}

foreach (var item in brics)
{
    Console.WriteLine($" Chave/Valor = {item.Key} {item.Value}");
}


