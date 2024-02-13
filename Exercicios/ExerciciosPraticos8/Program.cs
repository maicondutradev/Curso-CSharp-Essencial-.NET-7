namespace ExerciciosPraticos8
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente();
            cliente1.ExibirInfo(nome: "Maicon", email: "teste1@gmail.com", idade: 19);

            Cliente cliente2 = new Cliente();
            cliente2.ExibirInfo(nome: "Mirela", email: "teste2@gmail.com");
        }
    }

    public struct Cliente
    {
        public string? Nome { get; set; }
        public string? Email { get; set; }

        private static int idade;
        public static int Idade
        {
            get { return idade; }

            set
            {
                if (value < 18)
                {
                    Idade = 18;
                };
            }
        }

        public Cliente(string nome, string email, int idade)
        {
            Nome = nome;
            Email = email;
            Idade = idade;
        }

        public void ExibirInfo(string nome, string email, int idade = 23)
        {
            Console.WriteLine($"Nome: {nome} \n Email: {email} \n Idade: {idade}");
        }
    }
}