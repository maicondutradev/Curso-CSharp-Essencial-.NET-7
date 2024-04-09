//O primeiro a entrar é o primeiro a sair
Queue<string> diasSemana = new Queue<string>();

diasSemana.Enqueue("Segunda-Feira");
diasSemana.Enqueue("Terça-Feira");
diasSemana.Enqueue("Quarta-Feira");

ExibirFila(diasSemana);

Console.WriteLine("\nMétodo Dequeue - Remove item do início da fila");
diasSemana.Dequeue();

ExibirFila(diasSemana);

static void ExibirFila(Queue<string> diasSemana)
{
    foreach (var item in diasSemana)
    {
        Console.WriteLine(item);
    }
}