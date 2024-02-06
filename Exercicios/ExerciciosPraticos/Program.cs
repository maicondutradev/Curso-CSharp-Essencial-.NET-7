using System.Runtime.CompilerServices;

namespace ExerciciosPraticos
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro chevrolet = new Carro("Sedan", "Chevrolet", "Onix", 2016, 110);
            Console.WriteLine($" O modelo {chevrolet.Modelo}, da montadora {chevrolet.Montadora}, da marca {chevrolet.Marca}, do ano {chevrolet.Ano} com uma potencia de {chevrolet.Potencia} Cavalos!");
            chevrolet.Acelerar(chevrolet.Marca);



            Carro ford = new Carro("SUV", "Ford", "EcoSport", 2018, 120);
            Console.WriteLine($" O modelo {ford.Modelo}, da montadora {ford.Montadora}, da marca {ford.Marca}, do ano {ford.Ano} com uma potencia de {ford.Potencia} Cavalos!");
            chevrolet.Acelerar(ford.Marca);


            Console.ReadKey();
        }
    }

    public class Carro
    {
        public string? Modelo;
        public string? Montadora;
        public string? Marca;
        public int Ano;
        public int Potencia;


        public Carro(string modelo, string montadora, string marca, int ano, int potencia)
        {
            this.Modelo = modelo;
            this.Montadora = montadora;
            this.Marca = marca;
            this.Ano = ano;
            this.Potencia = potencia;
        }

        public void Acelerar(string marca)
        {
            Console.WriteLine($"Acelerando o meu {marca}");
        }
    }
}

