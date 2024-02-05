using System;

namespace ClassesObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chamando o método onde está o objeto para ser executado
            MinhasClasses();
        }

        // Método responsável por criar e exibir informações sobre pessoas
        static void Pessoas()
        {
            // Criando o primeiro objeto Pessoa (p1)
            Pessoa p1 = new Pessoa();
            p1.nome = "Maicon";
            p1.idade = 23;
            p1.sexo = "Masculino";
            Console.WriteLine($"{p1.nome} {p1.idade} {p1.sexo}");

            // Criando o segundo objeto Pessoa (p2)
            Pessoa p2 = new Pessoa();
            p2.nome = "Mirela";
            p2.idade = 22;
            p2.sexo = "Feminino";
            Console.WriteLine($"{p2.nome} {p2.idade} {p2.sexo}");
        }

        // Método responsável por criar e usar um objeto da classe MinhaClasse
        static void MinhasClasses()
        {
            // Criando um objeto da classe MinhaClasse
            MinhaClasse minhaClasse = new MinhaClasse();

            // Chamando o método Saudacao da classe MinhaClasse
            minhaClasse.Saudacao("Maicon", DateTime.Now.ToShortDateString());

            // Chamando o método ExibirDataAtual da classe MinhaClasse
            minhaClasse.ExibirDataAtual();
        }
    }

    // Classe representando uma Pessoa
    class Pessoa
    {
        public string? nome;
        public int idade;
        public string? sexo;
    }

    // Classe com métodos para exibição de saudação e data atual
    class MinhaClasse
    {
        // Método para exibir saudação com nome e data
        public void Saudacao(string nome, string data)
        {
            Console.WriteLine(nome);
            Console.WriteLine(data);
        }

        // Método para exibir a data atual
        public void ExibirDataAtual()
        {
            Console.WriteLine(DateTime.Now);
        }
    }
}
