namespace ExerciciosPraticos5
{
    class Program
    {
        static void Main(string[] args)
        {
            Informacao informacao = new Informacao();

            informacao.ExibirInfo(modelo: "Sedan", montadora: "Chevrolet", marca: "Onix", potencia: 110);
            Console.WriteLine(" ");
            informacao.ExibirInfo(modelo: "Sedan", montadora: "Chevrolet", marca: "Onix", potencia: 110, ano: 2016);
        }
    }

    public class Informacao
    {
        public void ExibirInfo(string modelo, string montadora, string marca, int potencia, int ano = 2010)
        {
            Console.WriteLine($"Modelo: {modelo} \n Montadora: {montadora} \n Marca: {marca} \n Potência: {potencia} \n Ano: {ano} ");
        }
    }
}