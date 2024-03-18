// Declaração e instância de um objeto genérico da classe ClasseGenerica<int>
ClasseGenerica<int> objInt = new ClasseGenerica<int>();

// Adiciona elementos ao objeto objInt
objInt.Adicionar(10);
objInt.Adicionar(20);
objInt.Adicionar(30);
objInt.Adicionar(40);
objInt.Adicionar(50);

// Imprime os elementos do objeto objInt usando um loop for
Console.WriteLine("Classe ClasseGenerica<T> de objetos int");
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(objInt[i]);
}

// Definição da classe genérica ClasseGenerica<T>
public class ClasseGenerica<T>
{
    // Array de tipo genérico T com 5 elementos
    T[] obj = new T[5];
    int contador = 0; // Variável para controlar o número de elementos adicionados

    // Método para adicionar elementos ao array
    public void Adicionar(T item)
    {
        if (contador < 5) // Verifica se ainda há espaço no array
        {
            obj[contador] = item; // Adiciona o elemento ao array na posição atual do contador
        }
        contador++; // Incrementa o contador após adicionar um elemento
    }

    // Indexador para acessar os elementos do array pelo índice
    public T this[int index]
    {
        get { return obj[index]; } // Retorna o elemento do array na posição do índice especificado
        set { obj[index] = value; } // Define o elemento do array na posição do índice especificado com o valor fornecido
    }
}
