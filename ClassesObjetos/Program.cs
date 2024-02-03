namespace ClassesObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoas();
        }

        static void Pessoas()
        {
            Pessoa p1 = new Pessoa();
            p1.nome = "Maicon";
            p1.idade = 23;
            p1.sexo = "Masculino";
            Console.WriteLine($"{p1.nome} {p1.idade} {p1.sexo}");


            Pessoa p2 = new Pessoa();
            p2.nome = "Mirela";
            p2.idade = 22;
            p2.sexo = "Feminino";
            Console.WriteLine($"{p2.nome} {p2.idade} {p2.sexo}");
        }

    }

    class Pessoa
    {
        public string? nome;
        public int idade;
        public string? sexo;

    }
}
