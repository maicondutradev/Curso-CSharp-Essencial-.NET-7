// Definição do namespace VirtualOverridd
namespace VirtualOverridd
{
    // Classe principal do programa
    class Program
    {
        // Método de entrada principal
        static void Main(string[] args)
        {
            // Criando uma instância da classe Cliente
            Cliente cliente = new Cliente();

            // Atribuindo um nome à propriedade Nome da instância
            cliente.Nome = "Maicon";

            // Chamando o método ExibeNome da classe Cliente
            cliente.ExibeNome();
        }
    }

    // Classe Pessoa, marcada como sealed para impedir a herança
    sealed class Pessoa
    {
        // Propriedade Nome que pode ser nula (?)
        public string? Nome { get; set; }

        // Método para exibir o nome
        public void ExibeNome()
        {
            // Exibindo o nome formatado
            Console.WriteLine($"\nMeu nome é {Nome}");
        }
    }

    // Classe Cliente, herda da classe Pessoa, Porém não pode pois a classe pessoa possui SLEADED = Impede a herança
    class Cliente : Pessoa
    {
        // Sobrescrevendo o método ExibeNome da classe base Pessoa usando "new"
        public new void ExibeNome()
        {
            // Exibindo o nome do cliente formatado
            Console.WriteLine($"\nNome do cliente: {Nome}");
        }
    }
}
