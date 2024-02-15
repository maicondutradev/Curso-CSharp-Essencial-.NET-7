var resultado = Calcular.Soma(1, 2, 3, 4, 5);

Console.WriteLine(resultado);

public class Calcular
{
    public static int Soma(params int[] numeros)
    {
        int total = 0;
        foreach (var numero in numeros)
        {
            total += numero;
        }
        return total;
    }
}