using System;

class Program
{
    static void Main(string[] args)
    {
        // Criando uma instância da ClasseGenerica para inteiros
        ClasseGenerica<int> intObj = new ClasseGenerica<int>();
        // Adicionando valores inteiros na coleção
        intObj.Adicionar(10);
        intObj.Adicionar(20);
        intObj.Adicionar(30);
        intObj.Adicionar(40);
        intObj.Adicionar(50);

        Console.WriteLine("Classe ClasseGenerica<M> de objetos int");
        // Exibindo os valores
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(intObj[i]);
        }

        // Criando uma instância da ClasseGenerica para strings
        ClasseGenerica<string> stringObj = new ClasseGenerica<string>();
        // Adicionando valores strings na coleção
        stringObj.Adicionar("Dez");
        stringObj.Adicionar("Vinte");
        stringObj.Adicionar("Trinta");
        stringObj.Adicionar("Quarenta");
        stringObj.Adicionar("Cinquenta");

        Console.WriteLine("\nClasse ClasseGenerica<M> de objetos string");
        // Exibindo os valores
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(stringObj[i]);
        }

        // Criando uma instância da ClasseGenerica para Aluno
        ClasseGenerica<Aluno> alunoObj = new ClasseGenerica<Aluno>();
        alunoObj.Adicionar(new Aluno { Nome = "Maicon" });

        Console.WriteLine("\nClasse ClasseGenerica<M> de objetos Aluno");
        // Exibindo os valores
        Console.WriteLine(alunoObj[0].Nome);

        Console.ReadKey();
    }
}

public class ClasseGenerica<T>
{
    // Definindo um array com 5 elementos
    T[] obj = new T[5];
    int contador = 0;

    // Método para adicionar um item na coleção
    public void Adicionar(T item)
    {
        if (contador < 5)
        {
            obj[contador] = item;
        }
        contador++;
    }

    // Indexador para permitir a iteração usando o operador []
    public T this[int index]
    {
        get { return obj[index]; }
        set { obj[index] = value; }
    }
}

public class Aluno
{
    public string Nome { get; set; }
}
