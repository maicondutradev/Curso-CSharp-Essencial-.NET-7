//Array de números inteiros simples.
int[] numeros = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
Console.WriteLine(numeros[2]);

//Array de strings, três maneiras de representar esse array.
string[] nome1 = new string[5] { "Maicon", "Mirela", "Izabel", "Mario", "Naruto" };
string[] nome2 = new string[] { "Maicon", "Mirela", "Izabel", "Mario", "Naruto" };
string[] nome3 = { "Maicon", "Mirela", "Izabel", "Mario", "Naruto" };
Console.WriteLine(nome3[1]);

//Criando um array sem passar os valores.
int[] numeros1;
numeros1 = new int[3];

//Adicionando valores ao array, por index.
numeros1[0] = 1;
numeros1[1] = 2;
numeros1[2] = 3;


