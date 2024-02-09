class Program
{
    private static void Main(string[] args)
    {
        var soma = Calculadora.Somar(5, 10);
        Console.WriteLine(soma);
    }
    public class Calculadora
    {
        public static int Somar(int n1, int n2)
        {
            Console.WriteLine($"Operação de adição dos valores {n1} + {n2} = {n1 + n2}");
            return n1 + n2;
        }

        public static int Subtrair(int n1, int n2)
        {
            Console.WriteLine($"Operação de subtração dos valores {n1} - {n2} = {n1 - n2}");
            return n1 - n2;
        }

        public static int Multiplicar(int n1, int n2)
        {
            Console.WriteLine($"Operação de Multiplicação dos valores {n1} * {n2} = {n1 * n2}");
            return n1 * n2;
        }

        public static int Dividir(int n1, int n2)
        {
            Console.WriteLine($"Operação de divisão dos valores {n1} / {n2} = {n1 / n2}");
            return n1 / n2;
        }
    }
}