public class Program
{
    public static void Main()
    {
        // Criando instâncias da classe Pessoa com diferentes valores
        Pessoa pessoa1 = new Pessoa(123456, "Mirela");
        Pessoa pessoa2 = new Pessoa(123456, "Mirela");
        Pessoa pessoa3 = new Pessoa(987654, "Maicon");

        // Exibindo os dados das pessoas criadas
        Console.WriteLine($"Pessoa1 -> CPF = {pessoa1.CPF} Nome = {pessoa1.Nome}");
        Console.WriteLine($"Pessoa2 -> CPF = {pessoa2.CPF} Nome = {pessoa2.Nome}");
        Console.WriteLine($"Pessoa3 -> CPF = {pessoa3.CPF} Nome = {pessoa3.Nome}");

        // Comparando os códigos hash das instâncias Pessoa
        Console.WriteLine("\nComparando objetos Pessoa - GetHashCode");
        Console.WriteLine($"pessoa1 = {pessoa1.GetHashCode()}");
        Console.WriteLine($"pessoa2 = {pessoa2.GetHashCode()}");
        Console.WriteLine($"pessoa3 = {pessoa3.GetHashCode()}");

        // Comparando a igualdade entre as instâncias Pessoa
        Console.WriteLine("\nComparando objetos Pessoa - Equals");
        Console.WriteLine($"pessoa1.Equals(pessoa2) = {pessoa1.Equals(pessoa2)}");
        Console.WriteLine($"pessoa2.Equals(pessoa3) = {pessoa2.Equals(pessoa3)}");
    }
}

// Definindo a classe Pessoa
public class Pessoa
{
    // Propriedades da classe Pessoa
    public int CPF { get; set; }
    public string Nome { get; set; }

    // Construtor da classe Pessoa
    public Pessoa(int cpf, string nome)
    {
        CPF = cpf;
        Nome = nome;
    }

    // Sobrescrevendo o método Equals para comparar a igualdade de duas instâncias Pessoa pelo CPF
    public override bool Equals(object? obj)
    {
        if (obj == null)
        {
            return false;
        }
        if (obj is not Pessoa)
        {
            return false;
        }

        var other = (Pessoa)obj;

        return CPF.Equals(other.CPF);
    }

    // Sobrescrevendo o método GetHashCode para retornar o código hash baseado no CPF
    public override int GetHashCode()
    {
        return CPF.GetHashCode();
    }
}
