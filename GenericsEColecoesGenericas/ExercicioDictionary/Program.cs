namespace ExercicioDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var alunos = new Dictionary<double, Aluno>()
            {
                {1, new Aluno("Maicon",8)},
                {2, new Aluno("Mirela",9)},
                {3, new Aluno("Naruto",2)},
                {4, new Aluno("Gojo",7)},
                {5, new Aluno("Utahime",9.5)}
            };

            ExibirColecao(alunos);

            AlteraNotasAlunos(alunos);

            ExibirColecao(alunos);

            RemoverAlunos(alunos);

            ExibirColecao(alunos);

            AdicionarNovoAluno(alunos);

            ExibirColecao(alunos);

            OrdenandoAlunosPorNome(alunos);
        }
        static void OrdenandoAlunosPorNome(Dictionary<double, Aluno> alunos)
        {
            Console.WriteLine("Alunos ordenados por nome: ");
            var alunosOrdenados = alunos.OrderBy(x => x.Value.Name);
            foreach (var item in alunosOrdenados)
            {
                Console.WriteLine($"{item.Key} {item.Value.Name} {item.Value.Nota}");
            }
        }
        static void AdicionarNovoAluno(Dictionary<double, Aluno> alunos)
        {
            Console.WriteLine("\n ### Incluindo um novo Aluno ###");
            Console.WriteLine("\nInforme o nome alunos: ");
            string? novoNome = Console.ReadLine();

            Console.WriteLine("Informe a nota do aluno: ");
            double novaNota = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o código do aluno: ");
            int novoCodigo = Convert.ToInt32(Console.ReadLine());

            if (!alunos.ContainsKey(novoCodigo))
            {
                alunos.Add(novoCodigo, new Aluno(novoNome, novaNota));
                Console.WriteLine("Aluno incluido com sucesso!");
            }
            else
            {
                Console.WriteLine("\nCódigo já existente encontrado!");
            }
        }
        static void RemoverAlunos(Dictionary<double, Aluno> alunos)
        {
            Console.WriteLine("\nInforme o código do Aluno a ser removido");
            int cod = Convert.ToInt32(Console.ReadLine());
            if (alunos.ContainsKey(cod))
            {
                alunos.Remove(cod);
                Console.WriteLine($"Aluno removido com sucesso!");
            }
            else
            {
                Console.WriteLine("\nCódigo não encontrado!");
            }
        }
        static void AlteraNotasAlunos(Dictionary<double, Aluno> alunos)
        {
            do
            {
                Console.WriteLine("\nInforme o código do Aluno a localizar (99 sai)");
                int codigo = Convert.ToInt32(Console.ReadLine());

                if (codigo == 99)
                {
                    break;
                }

                var resultado = alunos.ContainsKey(codigo);
                if (resultado)
                {
                    Console.WriteLine("Infome a nota (1 a 10)");
                    var nota = Convert.ToInt32(Console.ReadLine());
                    alunos[codigo].Nota = nota;
                }
                else
                {
                    Console.WriteLine("Aluno não encontrado!!!");
                }

            } while (true);
        }
        static void ExibirColecao(Dictionary<double, Aluno> alunos)
        {
            foreach (var item in alunos)
            {
                Console.WriteLine($"{item.Key} {item.Value.Name} {item.Value.Nota}");
            }
        }
    }

    public class Aluno
    {
        public Aluno(string? name, double nota)
        {
            Name = name;
            Nota = nota;
        }

        public string? Name { get; set; }
        public double Nota { get; set; }
    }

}