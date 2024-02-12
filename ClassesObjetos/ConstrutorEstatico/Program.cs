namespace ConstrutorEstatico
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa(23, "Maicon");
            Console.WriteLine($"{p1.Nome} - {p1.Idade}");
            Console.WriteLine($"Idade minima: {Pessoa.IdadeMinima}");

            Pessoa p2 = new Pessoa(22, "Mirela");
            Console.WriteLine($"{p2.Nome} - {p2.Idade}");
            Console.WriteLine($"Idade minima: {Pessoa.IdadeMinima}");
        }
    }


}