// Namespace do projeto
namespace ExerciciosPraticos3
{
    // Classe principal do programa
    class Program
    {
        // Método principal do programa
        static void Main(string[] args)
        {
            // Definindo e inicializando uma variável por valor
            int valorPorValor = 10;

            // Chamando o método AumentarPotencia com passagem por valor
            int resultadoPorValor = AumentarPotencia(valorPorValor);

            // Exibindo resultados da passagem por valor
            Console.WriteLine($"Passagem por Valor - Valor Original: {valorPorValor}, Novo valor: {resultadoPorValor}");

            // Definindo e inicializando uma variável por referência
            int valorPorReferencia = 15;

            // Chamando o método AumentarPotencia com passagem por referência
            int resultadoPorReferencia = AumentarPotencia(ref valorPorReferencia);

            // Exibindo resultados da passagem por referência
            Console.WriteLine($"Passagem por Referencia - Valor Original: {valorPorReferencia}, Novo valor: {resultadoPorReferencia}");
        }

        // Método que recebe um parâmetro por valor e retorna a potência aumentada
        public static int AumentarPotencia(int potencia)
        {
            // Aumenta a potência por valor
            int novaPotencia = potencia + 3;

            // Retorna a nova potência
            return novaPotencia;
        }

        // Método que recebe um parâmetro por referência e retorna a potência aumentada
        public static int AumentarPotencia(ref int potencia)
        {
            // Aumenta a potência por referência
            int novaPotencia = potencia + 5;

            // Retorna a nova potência
            return novaPotencia;
        }
    }
}
