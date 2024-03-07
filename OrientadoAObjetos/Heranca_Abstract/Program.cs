namespace Abstract;

class Program
{
    static void Main(string[] args)
    {
        Quadrado quadrado = new Quadrado();
        Console.WriteLine(quadrado.Descricao());

        Console.WriteLine("\nInforme a cor da figura: ");
        quadrado.Cor = Console.ReadLine();

        Console.WriteLine("\nInforme o valor do lado do quadrado: ");
        quadrado.Lado = Convert.ToInt32(Console.ReadLine());

        quadrado.CalcularArea();
        quadrado.CalcuraPerimetro();

        Console.WriteLine($"\nÁrea do quadrado : {quadrado.Area} m2");
        Console.WriteLine($"\nPerímetro do quadrado : {quadrado.Perimetro} m");
        Console.WriteLine($"\nO quadrado tem a cor: {quadrado.Cor}");


        Console.ReadKey();
    }
}