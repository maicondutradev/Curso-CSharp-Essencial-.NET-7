namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = "Maicon";
            cliente.Idade = 23;

            Console.WriteLine($"{cliente.Nome} {cliente.Idade}");
        }
    }

    public struct Cliente
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }
        public Cliente(string? nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
    }
}