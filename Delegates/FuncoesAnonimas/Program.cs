class Program
{
    private static void Main(string[] args)
    {
        Imprimir imprimir = delegate (int valor)
        {
            Console.WriteLine($"Método anônimo. Valor: {valor}");
        };

        imprimir(100);
    }

    public delegate void Imprimir(int valor);
}