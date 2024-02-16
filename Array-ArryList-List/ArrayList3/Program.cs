using System.Collections;

ArrayList lista = new ArrayList() { "Ana", 5, true, " ", null, 1.1, "Zé", 3, 9, 0 };

foreach (object element in lista)
{
    Console.WriteLine(element);
}

Console.WriteLine("///////////////////");
//Remove a primeira instância do valor escolhido, nesse caso a primeira aparição do null na lista.
lista.Remove(null);

foreach (object element in lista)
{
    Console.WriteLine(element);
}

Console.WriteLine("///////////////////");

//Remove a instância do valor escolhido, nesse cado o indice 4.
lista.RemoveAt(4);

foreach (object element in lista)
{
    Console.WriteLine(element);
}

Console.WriteLine("///////////////////");

//Remove uma quantidade de elementos a partir de tal local, nesse caso remove 2 elementos a partir do indice 0.
lista.RemoveRange(0, 2);

foreach (object element in lista)
{
    Console.WriteLine(element);
}