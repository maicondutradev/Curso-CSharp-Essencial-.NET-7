using System.Runtime.CompilerServices;

Console.WriteLine("Sorteio da MegaSena\n");

Random random = new Random();

int[] numerosSorteados = new int[6];

/*
    Console.WriteLine(random.Next());
    Console.WriteLine(random.Next(20));
    Console.WriteLine(random.Next(10, 20));
    Console.WriteLine(random.NextDouble());
*/

for (int i = 0; i < 6; i++)
{
    int numeroAleatorio;
    do
    {
        numeroAleatorio = random.Next(1, 61);
    } while (numerosSorteados.Contains(numeroAleatorio));

    numerosSorteados[i] = numeroAleatorio;
}

Array.Sort(numerosSorteados);

Console.WriteLine("Numeros Sorteados\n");

Console.WriteLine(string.Join(" ", numerosSorteados));


Console.ReadKey();