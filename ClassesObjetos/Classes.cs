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