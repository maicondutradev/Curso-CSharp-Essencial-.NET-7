namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Categorias1();
        }

        static void DiasDaSemana1()
        {
            //Caso eu queira exibir o valor númerico na tela
            var dia1 = (int)DiasDaSemana.Segunda;
            var dia2 = (int)DiasDaSemana.Terça;
            Console.WriteLine(dia1);
            Console.WriteLine(dia2);

            //Caso eu queira exibir o valor em string
            var dia3 = DiasDaSemana.Quarta;
            Console.WriteLine(dia3);


            Console.WriteLine($"\n{DiasDaSemana.Segunda} Vale: {dia1}");
            Console.WriteLine($"\n{DiasDaSemana.Terça} Vale: {dia2}");
        }

        static void Categorias1()
        {
            Console.WriteLine($"{Categorias.Moda} - {(int)Categorias.Moda}");
            Console.WriteLine($"{Categorias.Automotivo} - {(int)Categorias.Automotivo}");
            Console.WriteLine($"{Categorias.Artes} - {(int)Categorias.Artes}");
            Console.WriteLine($"{Categorias.Bebidas} - {(int)Categorias.Bebidas}");
            Console.WriteLine($"{Categorias.Livros} - {(int)Categorias.Livros}");
            Console.WriteLine($"{Categorias.Brinquedos} - {(int)Categorias.Brinquedos}");

            Console.WriteLine("\nSelecione a categoria teclando o seu valor: ");
            int valor = Convert.ToInt32(Console.ReadLine());

            var nomeMembroEnum = (Categorias)valor;

            Console.WriteLine($"Você selecionou a categoria: {nomeMembroEnum.ToString()}");
        }
    }
}