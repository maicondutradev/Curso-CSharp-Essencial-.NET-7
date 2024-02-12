public class Pessoa
    {
        public static int IdadeMinima;

        public int Idade { get; set; }
        public string Nome { get; set; } = string.Empty;

        public Pessoa(int idade, string nome)
        {
            Console.WriteLine("Executando o construtor parametrizado");
            Idade = idade;
            Nome = nome;
        }

        public Pessoa()
        { }

        static Pessoa()
        {
            Console.WriteLine("Executando o construtor estatico");
            Console.WriteLine("Inicializando o campo IdadeMinima");
            IdadeMinima = 18;
        }

    }