// Criando uma instância da classe Teste
Teste teste1 = new Teste();

// Criando instâncias da classe Teste2 com tipos genéricos int, float e string
Teste2<int, int> teste2 = new Teste2<int, int>();
Teste2<float, float> teste3 = new Teste2<float, float>();
Teste2<string, string> teste4 = new Teste2<string, string>();

// Declarando e inicializando variáveis de diferentes tipos
int i1 = 10;
int i2 = 10;

float f1 = 10;
float f2 = 10;

string s1 = "10";
string s2 = "10";

// Chamando o método Comparar da instância teste1 para comparar valores do mesmo tipo
teste1.Comparar(i1, i2);
teste1.Comparar(f1, f2);
teste1.Comparar(s1, s2);

// Chamando o método CompararTiposDiferentes da instância teste1 para comparar valores de tipos diferentes
teste1.CompararTiposDiferentes(i1, f2);
teste1.CompararTiposDiferentes(i1, s2);
teste1.CompararTiposDiferentes(s1, f2);

// Chamando o método Comparar da instância teste2 para comparar valores do mesmo tipo
teste2.Comparar(i1, i2);
teste3.Comparar(f1, f2);
teste4.Comparar(s1, s2);

Console.ReadKey();

// Definição da classe Teste
public class Teste
{
    // Método para comparar valores do mesmo tipo
    public void Comparar<T>(T p1, T p2)
    {
        Console.WriteLine($" Os tipos : {p1.GetType()} e {p2.GetType()}\n");
        var resultado = p1.Equals(p2);
        Console.WriteLine($"{p1} e {p2} são iguais ? {resultado}\n");
    }

    // Método para comparar valores de tipos diferentes
    public void CompararTiposDiferentes<T1, T2>(T1 p1, T2 p2)
    {
        Console.WriteLine($" Os tipos : {p1.GetType()} e {p2.GetType()}\n");
        var resultado = p1.Equals(p2);
        Console.WriteLine($"{p1} e {p2} são iguais ? {resultado}\n");
    }
}

// Definição da classe Teste2 com restrição a tipos de valor (struct)
class Teste2<T1, T2> where T1 : struct where T2 : struct
{
    // Método para comparar valores de tipos diferentes (com restrição a tipos de valor)
    public void Comparar(T1 p1, T2 p2)
    {
        Console.WriteLine($" Os tipos : {p1.GetType()} e {p2.GetType()}\n");
        var resultado = p1.Equals(p2);
        Console.WriteLine($"{p1} e {p2} são iguais ? {resultado}\n");
    }
}
