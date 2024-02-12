// Namespace Propriedades
namespace Propriedades
{
    // Classe Program
    class Program
    {
        // Método principal
        static void Main(string[] args)
        {
            // Criando uma instância da classe Produto
            Produto p1 = new Produto();

            // Configurando propriedades da instância
            p1.Nome = "Mochila";
            p1.Preco = 4.00;
            p1.EstoqueMinimo = 10;

            // Chamando o método Exibir para mostrar as informações do produto
            p1.Exibir();
        }
    }
}