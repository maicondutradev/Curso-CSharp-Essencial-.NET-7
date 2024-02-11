// Definindo um namespace chamado ExemploPratico
namespace ExemploPratico
{
    // Definindo uma classe chamada Program
    class Program
    {
        // Método principal que será executado quando o programa iniciar
        static void Main(string[] args)
        {
            Clientes();
        }
        //Criando o objeto da classe cliente e cadastro
        static void Clientes()
        {
            // Criando uma instância da classe Cadastro
            Cadastro cadastro = new Cadastro();

            // Registrando um novo cliente usando o método Registar da classe Cadastro
            var cliente = cadastro.Registar();

            // Exibindo os dados do cliente usando o método ExibirDados da classe Cadastro
            cadastro.ExibirDados(cliente);

            // Atualizando a renda do cliente e registrando novamente usando o método sobrecarregado Registar
            cliente = cadastro.Registar(cliente);

            // Exibindo os dados do cliente com uma mensagem personalizada usando o método sobrecarregado ExibirDados
            cadastro.ExibirDados("Renda alterada", cliente);
        }
    }
    // Definindo uma classe chamada Cliente
    public class Cliente
    {
        // Propriedades da classe Cliente
        public string? Nome;
        public int Idade;
        public decimal Renda;

        // Construtor para inicializar as propriedades da classe Cliente
        public Cliente(string? nome, int idade, decimal renda)
        {
            Nome = nome;
            Idade = idade;
            Renda = renda;
        }

        // Construtor vazio
        public Cliente()
        { }
    }

    // Definindo uma classe chamada Cadastro
    public class Cadastro
    {
        // Método para registrar um novo cliente com valores padrão
        public Cliente Registar()
        {
            Cliente cliente = new Cliente("Maicon", 23, 900);
            return cliente;
        }

        // Método sobrecarregado para atualizar a renda de um cliente existente
        public Cliente Registar(Cliente cliente)
        {
            cliente.Renda = 1300;
            return cliente;
        }

        // Método para exibir os dados de um cliente
        public void ExibirDados(Cliente cliente)
        {
            Console.WriteLine($"{cliente.Nome} {cliente.Idade} {cliente.Renda.ToString("c")}");
        }

        // Método sobrecarregado para exibir dados com uma mensagem personalizada
        public void ExibirDados(string texto, Cliente cliente)
        {
            Console.Write($"\n {texto}\t");
            Console.Write($" {cliente.Nome} {cliente.Renda.ToString("c")}");
        }
    }
}
