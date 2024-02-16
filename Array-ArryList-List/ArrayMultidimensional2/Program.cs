class Program
{
    static void Main(string[] args)
    {
        // Criando uma matriz bidimensional (array) de inteiros com dimensões 3x3
        int[,] n = new int[3, 3] {
            { 11, 22, 33 }, // Linha 0: n[0,0], n[0,1], n[0,2]
            { 44, 55, 66 }, // Linha 1: n[1,0], n[1,1], n[1,2]
            { 77, 88, 99 }  // Linha 2: n[2,0], n[2,1], n[2,2]
        };

        // Loop externo para percorrer as linhas da matriz
        for (int i = 0; i < n.GetLength(0); i++)
        {
            // Loop interno para percorrer as colunas da matriz
            for (int j = 0; j < n.GetLength(1); j++)
            {
                // Imprime o valor do elemento atual da matriz
                Console.WriteLine($"{n[i, j]}");
            }
        }
    }
}
