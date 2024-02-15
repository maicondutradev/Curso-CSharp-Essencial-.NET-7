namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayNomes();
        }
        static void ArrayNumeros()
        {
            int[] numeros = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }
        }
        static void ArrayNomes()
        {
            string[] nomes = new string[] { "Maicon", "Mirela", "Izabel", "Naruto", "Yuta" };
            foreach (string nome in nomes)
            {
                Console.WriteLine(nome);
            }
        }
    }
}