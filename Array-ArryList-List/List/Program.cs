//Iniciando uma list
List<string> palavras = new List<string>() { "Maicon", "Mirela", "Naruto" };

//Adicionando elementos no final da lista
palavras.Add("Kakashi");
palavras.Add("Sakura");

//Adicionando elementos no local escolhido na lista. Neste exp estamos adicionando a palavra Julia no indice 2.
palavras.Insert(2, "Julia");

//Iniciando uma list
List<string> frutas = new List<string>() { "Abacate", "Maça", "Uva" };

//Adicionando todos os elementos da lista frutas no final da lista palavras.
palavras.AddRange(frutas);

//Iniciando uma list
List<string> carros = new List<string>() { "Gol", "Fiat", "BMW" };

//Adicionando todos os elementos da lista carros no indice escolhido na lista palavras. Neste caso indice 4.
palavras.InsertRange(4, carros);

foreach (string nome in palavras)
{
    Console.WriteLine(nome);
}

Console.WriteLine("/////////////////////////");

//Remove a primeira ocorrência de um objeto específico
palavras.Remove("Abacate");

//Remove o elemento do indice especificado.
palavras.RemoveAt(3);

//Remove um número definido de elementos a partir de um índice especificado.
palavras.RemoveRange(0, 2);

//Acessando um elemento pelo indice. Neste exemplo estamos acessando o primeiro elemento da lista
var primeiro = palavras[0];

//Atualizando o valor de um elemento pelo índice.
palavras[0] = "Izabel";

//Iterando sobre a lista utilazando foreach
foreach (string nome in palavras)
{
    Console.WriteLine(nome);
}

Console.WriteLine("/////////////////////////");

//Iterando sobre a lista utilizando for
for (int i = 0; i < palavras.Count; i++)
{
    Console.WriteLine($"{palavras[i]}");
}

Console.WriteLine("/////////////////////////");

//Verificando se o elemento especificado existe na lista. TRUE = Existe / FALSE = Não existe
var res1 = palavras.Contains("Izabel");
bool res2 = palavras.Contains("ABC");
Console.WriteLine(res1);
Console.WriteLine(res2);

//Ordenando os elementos na lista em ordem crescente. Ordem numerica, ordem alfabetica etc.
palavras.Sort();

//Iterando sobre a lista utilazando foreach
foreach (string nome in palavras)
{
    Console.WriteLine(nome);
}

//Exclui toda a lista
palavras.Clear();