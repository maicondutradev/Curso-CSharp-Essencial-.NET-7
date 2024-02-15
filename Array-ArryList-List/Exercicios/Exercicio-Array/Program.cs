namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chama o método Alunos para executar o programa principal
            Alunos();
        }

        static void Alunos()
        {
            // Declaração de arrays para armazenar nomes e notas dos alunos
            string?[] nomes = new string[5];
            double[] notas = new double[5];

            // Loop para coletar informações de cinco alunos
            for (int i = 0; i < 5; i++)
            {
                // Solicita ao usuário que digite o nome do aluno e armazena no array 'nomes'
                Console.WriteLine("Digite seu nome: ");
                string? nome = Console.ReadLine();
                nomes[i] = nome;

                // Solicita ao usuário que digite a nota do aluno e armazena no array 'notas'
                Console.WriteLine("Digite sua nota: ");
                double nota = Convert.ToDouble(Console.ReadLine());
                notas[i] = nota;
            }

            // Exibe as notas dos alunos após a coleta
            Console.WriteLine($"Notas dos alunos: ");
            for (int i = 0; i < 5; i++)
            {
                // Exibe o nome e a nota associada de cada aluno
                Console.WriteLine($"O aluno {nomes[i]} ficou com a nota: {notas[i]}");
            }
        }
    }
}
