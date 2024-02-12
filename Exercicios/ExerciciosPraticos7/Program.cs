using System.Runtime.CompilerServices;

namespace ExerciciosPraticos
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro chevrolet = new Carro("Sedan", "Chevrolet", "Onix", 2025, 110);
            Console.WriteLine($"{chevrolet.Modelo} \n{chevrolet.Montadora} \n{chevrolet.Marca} \n{chevrolet.Ano} \n{chevrolet.Potencia}");

            Console.ReadKey();
        }
    }

    public class Carro
    {
        public string? Modelo;
        public string? Montadora;
        public string? Marca;

        private int ano;
        public int Ano
        {
            get { return ano; }
            set
            {
                if (value < 2000)
                {
                    ano = 2000;
                }
                else if (value > 2022)
                {
                    ano = 2022;
                }
                else
                {
                    ano = value;
                }
                ;
            }
        }

        public int Potencia;


        public Carro(string modelo, string montadora, string marca, int ano, int potencia)
        {
            Modelo = modelo;
            Montadora = montadora;
            Marca = marca;
            Ano = ano;
            Potencia = potencia;
        }
    }
}

