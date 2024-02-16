using System.Collections;

ArrayList lista = new ArrayList() { "Maria", 5, true, " ", null };

//Adiciona no final da lista
lista.Add(3.5);

//Adicionando em um lugar escolhido da lista
lista.Insert(2, "Paulo");

foreach (object element in lista)
{
    Console.WriteLine(element);
}

///////////////////////////////////////////////////////////////

Console.WriteLine("\n");

ArrayList lista2 = new ArrayList() { "Mirela", 17, true };

ArrayList listaAdd = new ArrayList() { 1, 2, 3 };

ArrayList listaAdd2 = new ArrayList() { 4, 5, 6 };

//Adicionando uma lista inteira no final da lista escolhida
lista2.AddRange(listaAdd);

//Adicionando uma lista inteira no local desejado da lista escolhida
lista2.InsertRange(2, listaAdd2);

foreach (object element in lista2)
{
    Console.WriteLine(element);
}

