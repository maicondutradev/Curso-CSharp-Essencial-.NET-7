using System.Collections;

//1 maneira de criar um array list
ArrayList lista1;
lista1 = new ArrayList();

//2 maneira de criar um array list
ArrayList lista2 = new ArrayList();

//3 maneira de criar um array list
var lista3 = new ArrayList();

//4 maneira de criar um array list
ArrayList lista4 = new();

//Iniciando o array list com uma capacidade de 5
ArrayList listaCapac = new ArrayList(5);

//Inicando o array list e adicionando valores.
ArrayList listaTeste = new ArrayList();
listaTeste.Add("Paulo");
listaTeste.Add(4.5);
listaTeste.Add(5);
listaTeste.Add(true);
listaTeste.Add(" ");
listaTeste.Add(null);

//Inicando o array list com inicializadores de valor.
ArrayList listaPratica = new ArrayList() { "Paulo", 4.5, 5, true, " ", null };
