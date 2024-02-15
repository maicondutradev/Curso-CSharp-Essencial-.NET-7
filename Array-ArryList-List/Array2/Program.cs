namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayNomes();
        }
        static void ArrayInt()
        {
            int[] numeros = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"Elemento de índice {i} : {numeros[i]}");
            }
        }
        static void ArrayNomes()
        {
            string[] nomes = new string[] { "Maicon", "Mirela", "Izabel", "Gabriel", "Julio" };
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine($"Elemento do índice {i} : {nomes[i]}");
            }
        }
    }
}