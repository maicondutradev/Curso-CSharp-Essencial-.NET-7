using System.Security.Cryptography.X509Certificates;

namespace Exercicios;
class Program
{
    static void Main(string[] args)
    {
        //1
        int idade = 35;
        Console.WriteLine(idade);

        //2
        string nome = "Maria";
        Console.WriteLine(nome);

        //3
        float altura = 3.45f;
        Console.WriteLine(altura);

        //4
        DateTime data = new DateTime(04, 09, 1999);
        Console.WriteLine(data);

        //5
        const int ANO = 12;
        Console.WriteLine(ANO);

        //6
        double? nota = 7.80;
        Console.WriteLine(nota);

        //7
        /*
            Tipos por valor:
            Armazenamento: Contêm seus dados diretamente dentro da variável. São armazenados na pilha (stack) de memória.
            Atribuição: Ao atribuir um tipo por valor a outra variável, uma cópia do valor original é criada.
            Modificação: Modificar o valor de uma variável tipo valor não afeta outras variáveis que referenciam o mesmo valor original.
            Exemplos: int, float, bool, char, struct, enum.

            Tipos por referência:
            Armazenamento: Contêm um endereço de memória que aponta para o local onde os dados reais são armazenados. São armazenados no heap de memória.
            Atribuição: Ao atribuir um tipo por referência a outra variável, ambas as variáveis apontam para o mesmo local na memória.
            Modificação: Modificar o valor de uma variável tipo referência afeta todas as outras variáveis que referenciam o mesmo local na memória.
            Exemplos: class, interface, delegate, array.
        */

        //8
        int x = 10;
        double numero = 7.99;
        char letra = 'C';
        float temperatura = 27.4f;
        bool ativo = false;
        string nome1 = "Manoel";
        decimal salario = 950.99m;
        DateTime hoje = DateTime.Now;


        //9
        int n = 1; //(V)
        string titulo = "A vida"; //(V)
        float f = 12.45f;//(V)
        double d = 5.45;//(V)
        decimal valor = 10.99m;//(V)
        char sexo = 'M';//(V)
        object o = null;//(R)

        //10
        /*
            Em C#, um "nullable type" (tipo nulo) refere-se a um tipo de dados que pode armazenar tanto um valor normal do tipo subjacente quanto um valor nulo. Isso é alcançado adicionando um ponto de interrogação (?) após o tipo de dados subjacente. Por exemplo, int? é um tipo de dado nullable baseado no tipo int.

            A utilidade dos tipos nulos em C# está relacionada principalmente à capacidade de representar a ausência de um valor em situações em que um tipo de dados normal não permitiria isso. Normalmente, os tipos de valor em C# não podem ter um valor nulo, o que significa que eles sempre têm algum valor válido. No entanto, existem situações em que precisamos representar explicitamente a ausência de um valor, e é aí que os tipos nulos se tornam úteis.

            Ao usar tipos nulos, você pode distinguir entre um valor atribuído explicitamente como nulo e um valor que ainda não foi atribuído. Isso é particularmente útil em bancos de dados, operações de consulta e muitos outros cenários onde a ausência de um valor é uma consideração importante.
        */

        //11
        //(Camel Case) A primeira letra minuscula e as proximas palavras com a letra maiuscula
        string nomeDoMeuIrmao = "";

        //12
        //(Pascal Case) A primeira letra é maiuscula
        static void HelloWorld()
        {

        }


        //13
        int a = 77;
        int b = 66;
        Console.WriteLine(a + b);


    }
}
