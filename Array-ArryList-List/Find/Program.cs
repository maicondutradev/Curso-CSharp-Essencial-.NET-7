List<string> frutas = new List<string>()
{
    "Uva","Banana","Maça","Abacate","Laranja","Morango"
};

//Usando o Predicado como uma função
var fruta1 = frutas.Find(Procura);
Console.WriteLine($"Usando Predicado - {fruta1}");

//Usando a expressão lambda
var fruta2 = frutas.Find(f => f.Contains('n'));
Console.WriteLine($"Expressão Lambda - {fruta2}");

//Usando o Predicado como uma função
static bool Procura(string item)
{
    return item.Contains('n');

    //return item.StartsWith('L');
}

