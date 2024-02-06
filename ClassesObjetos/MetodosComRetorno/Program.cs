
namespace MetodosComRetorno
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora cal = new Calculadora();
            cal.Somar(10, 2);
            cal.Subtrair(10, 2);
            cal.Multiplicar(10, 2);
            cal.Dividir(10, 2);
        }
    }

    public class Calculadora
    {
        public int Somar(int n1, int n2)
        {
            Console.WriteLine($"Operação de adição dos valores {n1} + {n2} = {n1 + n2}");
            return n1 + n2;
        }

        public int Subtrair(int n1, int n2)
        {
            Console.WriteLine($"Operação de subtração dos valores {n1} - {n2} = {n1 - n2}");
            return n1 - n2;
        }

        public int Multiplicar(int n1, int n2)
        {
            Console.WriteLine($"Operação de Multiplicação dos valores {n1} * {n2} = {n1 * n2}");
            return n1 * n2;
        }

        public int Dividir(int n1, int n2)
        {
            Console.WriteLine($"Operação de divisão dos valores {n1} / {n2} = {n1 / n2}");
            return n1 / n2;
        }
    }

}


