namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayNumeros();
        }
        static void ArrayNumeros()
        {
            int[] numeros = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Exibindo o array original...");
            ExibeArray(numeros);

            Console.WriteLine("Invertendo a ordem do array...");
            System.Array.Reverse(numeros);
            ExibeArray(numeros);

            Console.WriteLine("Ordenando o array...");
            System.Array.Sort(numeros);
            ExibeArray(numeros);

            Console.WriteLine("Localizando um item no array...");
            Console.WriteLine("Informe o número: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            var indice = System.Array.BinarySearch(numeros, numero);

            if (indice >= 0)
            {
                Console.WriteLine($"{numero} foi encontrado no índice = {indice}");
            }
            else
            {
                Console.WriteLine($"{numero} Não foi encontrado...");
            }
        }
        static void ExibeArray(int[] numeros)
        {
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }
        }
    }
}