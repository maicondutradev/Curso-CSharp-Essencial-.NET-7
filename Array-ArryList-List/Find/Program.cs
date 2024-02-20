List<string> frutas = new List<string>()
{
    "Uva","Banana","Maça","Abacate","Laranja","Morango"
};

//Usando o Predicado como uma função
var fruta1 = frutas.Find(Procura);
Console.WriteLine($"Usando Predicado - {fruta1}");

//Usando a expressão lambda Find
var fruta2 = frutas.Find(i => i.Contains('n'));
Console.WriteLine($"Expressão Lambda Find - {fruta2}");

//Usando a expressão lambda FindLast
var fruta3 = frutas.FindLast(i => i.Contains('n'));
Console.WriteLine($"Expressão Lambda FindLast - {fruta3}");

//Usando a expressão lambda FindIndex
var fruta4 = frutas.FindIndex(i => i.Contains('n'));
Console.WriteLine($"Expressão Lambda FindIndex - {fruta4} / item = {frutas[fruta4]}");

//Usando a expressão lambda FindLastIndex
var fruta5 = frutas.FindLastIndex(i => i.Contains('n'));
Console.WriteLine($"Expressão Lambda FindLastIndex - {fruta5} / item = {frutas[fruta5]}");

//Usando a expressão lambda FindAll
var frutas6 = frutas.FindAll(i => i.Contains('n'));
foreach (string item in frutas6)
{
    Console.WriteLine($"Expressão Lambda FindAll - {item}");
}


//Usando o Predicado como uma função
static bool Procura(string item)
{
    return item.Contains('n');

    //return item.StartsWith('L');
}

