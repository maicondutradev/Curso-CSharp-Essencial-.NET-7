using System.Collections;

ArrayList lista = new ArrayList() { "Ana", 5, true, " ", null, 1.1, "Zé", 3, 9, 0 };

//Serve para verificar se o elemento especificado existe na ArrayList. True = Existe / False = Não existe
bool res1 = lista.Contains("Ana");
Console.WriteLine(res1);
var res2 = lista.Contains(10);
Console.WriteLine(res2);



ArrayList nomes = new ArrayList() { "Mirela", "Izabel", "Alice", "Gabriel", "João" };

//Serve para ordernar os elementos de uma lista. No caso de string ordena em ordem alfabetica, e em numeros em ordem numerica.
nomes.Sort();

foreach (string nome in nomes)
{
    Console.WriteLine(nome);
}
/////////////////////////////////////////////////////////////////

Console.WriteLine("\n");

ArrayList numeros = new ArrayList() { 3, 6, 1, 7, 4 };

//Serve para ordernar os elementos de uma lista. No caso de string ordena em ordem alfabetica, e em numeros em ordem numerica.
numeros.Sort();

foreach (int numero in numeros)
{
    Console.WriteLine(numero);
}

/////////////////////////////////////////////////////////////////

Console.WriteLine("\n");

ArrayList elementos = new ArrayList() { 3, 6, 1, 7, 4 };

//Remove todos os elementos de uma lista
elementos.Clear();

foreach (int elemento in elementos)
{
    Console.WriteLine(elemento);
}