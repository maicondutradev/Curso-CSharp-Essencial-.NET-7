using System;

namespace ClassesObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            ObterInformacoesAlunos();
        }

        // Método responsável por criar e usar um objeto da classe Aluno e Curso
        static void ObterInformacoesAlunos()
        {
            Aluno aluno = new Aluno();

            Console.WriteLine("Nome: ");
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("Idade: ");
            aluno.Idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sexo: ");
            aluno.Sexo = Console.ReadLine();

            Console.WriteLine("Aprovado (S)im (N)ão: ");
            aluno.Aprovado = Console.ReadLine();

            Curso curso = new Curso();
            curso.Resultado(aluno.Nome, aluno.Idade, aluno.Sexo, aluno.Aprovado);
        }
        // Método responsável por criar e usar um objeto da classe Pessoa
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

}
