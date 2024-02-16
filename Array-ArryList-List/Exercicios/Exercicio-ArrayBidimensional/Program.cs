// Cria uma matriz de strings com 2 linhas e 5 colunas
string[,] alunos = new string[2, 5];

// Imprime uma mensagem indicando que dados serão atribuídos à matriz
Console.WriteLine("\nAtribuindo dados a um array de strings com 2 linhas e 5 colunas[2,5]\n");

// Imprime os dados iniciais das duas linhas da matriz
Console.WriteLine("{Maria, Paulo, Marta, Pedro, Carlos}");
Console.WriteLine("{Silvia, Pedro, Alicia, Manoel, Paula} \n");

// Loop para preencher a matriz com dados fornecidos pelo usuário
for (int i = 0; i < alunos.GetLength(0); i++)
{
    for (int j = 0; j < alunos.GetLength(1); j++)
    {
        // Solicita ao usuário para informar o valor para o elemento na posição [i, j]
        Console.WriteLine($"Informe o valor para o elemento na posição [{i},{j}]");
        
        // Armazena a entrada do usuário na matriz
        alunos[i, j] = Console.ReadLine();
    }
}

// Imprime o conteúdo da matriz após ser preenchida
Console.WriteLine("\nConteudo do array alunos \n");

// Loop para percorrer e imprimir todos os elementos da matriz
for (int i = 0; i < alunos.GetLength(0); i++)
{
    for (int j = 0; j < alunos.GetLength(1); j++)
    {
        // Imprime o valor do elemento na posição [i, j]
        Console.WriteLine($"[{i},{j}] = {alunos[i, j]}");
    }
}
