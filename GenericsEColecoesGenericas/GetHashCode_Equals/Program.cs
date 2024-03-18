public class Program
{
    public static void Main()
    {
        // Criando duas strings iguais
        string a = "Mirela";
        string b = "Mirela";

        // Criando dois inteiros iguais
        int x = 22;
        int z = 22;

        // Comparando as strings utilizando o método Equals
        Console.WriteLine(a.Equals(b)); // True, porque a e b contêm a mesma sequência de caracteres

        // Comparando os inteiros utilizando o método Equals
        Console.WriteLine(x.Equals(z)); // True, porque x e z têm o mesmo valor

        // Obtendo o código hash das strings
        Console.WriteLine(a.GetHashCode()); // Hash code da string a
        Console.WriteLine(b.GetHashCode()); // Hash code da string b

        // Obtendo o código hash dos inteiros
        Console.WriteLine(x.GetHashCode()); // Hash code do inteiro x
        Console.WriteLine(z.GetHashCode()); // Hash code do inteiro z

        // Criando duas instâncias da classe Pessoa com os mesmos valores
        Pessoa pessoa1 = new Pessoa(id: 1, nome: "Maicon");
        Pessoa pessoa2 = new Pessoa(id: 1, nome: "Maicon");

        // Comparando as instâncias da classe Pessoa utilizando o método Equals
        Console.WriteLine(pessoa1.Equals(pessoa2)); // False, porque as referências são diferentes

        // Obtendo o código hash das instâncias da classe Pessoa
        Console.WriteLine(pessoa1.GetHashCode()); // Hash code da instância pessoa1
        Console.WriteLine(pessoa2.GetHashCode()); // Hash code da instância pessoa2
    }
}

// Definindo a classe Pessoa
public class Pessoa
{
    // Propriedades da classe Pessoa usando um Construtor
    public Pessoa(int id, string? nome)
    {
        Id = id;
        Nome = nome;
    }
    public int Id { get; set; }
    public string? Nome { get; set; }
}
