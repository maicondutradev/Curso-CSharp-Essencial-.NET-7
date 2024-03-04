namespace VirtualOverridd
{
    class Program
    {
        static void Main(string[] args)
        {
            Gato gato = new Gato();
            gato.Nome = "Mel";
            gato.ExibeNome();

            Cachorro cachorro = new Cachorro();
            cachorro.Nome = "Faisca";
            cachorro.ExibeNome();

            Console.ReadKey();
        }
    }
    //Classe Base
    class Animal
    {
        public string? Nome { get; set; }
        public virtual void ExibeNome()
        {
            Console.WriteLine($"\nMeu nome é {Nome}");
        }
    }
    //Classe derivada
    class Gato : Animal
    {
        public override void ExibeNome()
        {
            Console.WriteLine($"\nEu sou um gato. Meu nome é : {Nome}");
        }
    }

    class Cachorro : Animal
    {

    }

}