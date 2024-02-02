namespace EstruturaControle;
class Program
{
    static void Main(string[] args)
    {
        NumeroParWhile();
    }

    static void While()
    {
        int valor = 0;

        while (valor < 10)
        {
            valor++;
            Console.WriteLine(valor);
        }

        int valor2 = 10;

        while (valor2 > 0)
        {
            valor2--;
            Console.WriteLine(valor2);
        }
    }

    static void TabuadaWhile()
    {
        int contador = 0;
        int numero;

        Console.WriteLine("Digite um número inteiro: ");
        numero = Convert.ToInt32(Console.ReadLine());

        if (numero > 0)
        {
            while (contador < 10)
            {
                contador++;
                Console.WriteLine($"{numero} x {contador} = {numero * contador}");
            }
        }
        else
        {
            Console.WriteLine("Fim do processamento");
        }


    }

    static void NumeroParWhile()
    {
        while (true)
        {
            Console.WriteLine("Digite um número inteiro: (Para sair tecle 999)");
            int valor = Convert.ToInt32(Console.ReadLine());

            if (valor == 999)
            {
                break;
            }

            if (valor % 2 == 0)
            {
                Console.WriteLine("O número é par!");
            }
            else
            {
                Console.WriteLine("O número é impar");
            }

        }
    }
}
