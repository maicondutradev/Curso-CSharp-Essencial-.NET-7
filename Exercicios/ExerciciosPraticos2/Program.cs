namespace ExerciciosPraticos2
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro("Sedan", "Chevrolet");
            Console.WriteLine($"O carro do modelo {carro.Modelo} e da montadora {carro.Montadora}");



        }
    }

    public class Carro
    {

        public string Modelo;
        public string Montadora;

        public Carro(string modelo, string montadora)
        {
            Modelo = modelo;
            Montadora = montadora;

            /*
                Comportamento do Construtor:
                O construtor da classe Carro é utilizado para criar objetos do tipo Carro quando a linha Carro carro = new Carro("Sedan", "Chevrolet"); é executada no método Main.
                Este construtor atribui os valores dos parâmetros modelo e montadora às propriedades correspondentes (Modelo e Montadora) da instância recém-criada.
            */
        }


        public double VelocidadeMaximo(int potencia)
        {
            return potencia * 1.75;

            /*
                Comportamento da Palavra-Chave return:
                A palavra-chave return é usada no método VelocidadeMaximo.
                Esse método recebe um parâmetro potencia e calcula a velocidade máxima com base nessa potência multiplicada por 1.75.
                O valor calculado é, então, retornado pelo método usando a palavra-chave return.
                No contexto de um método, return é usado para devolver um valor e encerrar a execução do método. Neste caso, o resultado do cálculo é retornado à chamada do método.
            */
        }
    }

}