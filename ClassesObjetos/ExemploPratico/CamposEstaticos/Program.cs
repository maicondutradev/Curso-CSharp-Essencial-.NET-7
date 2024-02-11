
ContaCorrente c1 = new ContaCorrente();
c1.Conta = 501;
c1.Nome = "Maicon";

ContaCorrente c2 = new ContaCorrente();
c2.Conta = 502;
c2.Nome = "Mirela";


ContaCorrente.Juros = 4.99f;

Console.WriteLine($"Cliente: {c1.Nome} - Juros Anual: {c1.JurosAnual()}");

Console.WriteLine($"Cliente: {c2.Nome} - Juros Anual: {c2.JurosAnual()}");

public class ContaCorrente
{
    public int Conta;
    public string? Nome;
    public static float Juros;



    public float JurosAnual()
    {
        return Juros * 12;
    }
}