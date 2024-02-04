namespace ClassesObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chamando o metodo onde está o objeto para ser executado
            MinhasClasses();
        }


        //Criando o objeto
        static void Pessoas()
        {
            Pessoa p1 = new Pessoa();
            p1.nome = "Maicon";
            p1.idade = 23;
            p1.sexo = "Masculino";
            Console.WriteLine($"{p1.nome} {p1.idade} {p1.sexo}");


            Pessoa p2 = new Pessoa();
            p2.nome = "Mirela";
            p2.idade = 22;
            p2.sexo = "Feminino";
            Console.WriteLine($"{p2.nome} {p2.idade} {p2.sexo}");
        }

        //Criando o objeto
        static void MinhasClasses()
        {
            MinhaClasse minhaClasse = new MinhaClasse();
            minhaClasse.Saudacao();
        }
    }


    //Aprendendo como usar propriedades em uma classe
    class Pessoa
    {
        public string? nome;
        public int idade;
        public string? sexo;

    }


    //Aprendendo como usar metodos em uma classe
    class MinhaClasse
    {
        public void Saudacao()
        {
            Console.WriteLine("Bem-vindo!");
            Console.WriteLine("04/02/2024");
        }
    }
}
