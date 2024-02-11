using System.Runtime.InteropServices;

namespace ExerciciosPraticos6
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro.ObterValorIPVA();
            Console.WriteLine(Carro.ValorIpva);
        }
    }

    public class Carro
    {
        public static double ValorIpva = 2.5;

        public static void ObterValorIPVA()
        {
            ValorIpva += 4;
        }
    }
}