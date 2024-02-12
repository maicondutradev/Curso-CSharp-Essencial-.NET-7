// Classe pública Produto
public class Produto
{
    // Campo privado para armazenar o nome do produto
    private string? nome;

    // Propriedade Nome com getter e setter
    public string? Nome
    {
        // Getter retorna o nome em maiúsculas
        get { return nome.ToUpper(); }
        // Setter define o valor do nome
        set { nome = value; }
    }

    // Campo privado para armazenar o preço do produto
    private double preco;

    // Propriedade Preco com getter e setter
    public double Preco
    {
        // Getter retorna o preço
        get { return preco; }
        // Setter verifica se o valor é menor que 5.00 e ajusta para 5.00 se necessário
        set
        {
            if (value < 5.00)
            {
                preco = 5.00;
            }
            else
            {
                preco = value;
            }
        }
    }

    // Campo privado para armazenar o desconto padrão
    private double desconto = 0.05;

    // Propriedade Desconto apenas com getter
    public double Desconto
    {
        // Getter retorna o valor do desconto
        get { return desconto; }
    }

    // Propriedade calculada para obter o preço final considerando o desconto
    public double PrecoFinal
    {
        // Getter retorna o preço com desconto aplicado
        get { return Preco - Preco * Desconto; }
    }

    // Campo privado para armazenar o estoque mínimo
    private int estoqueMinimo;

    // Propriedade EstoqueMinimo apenas com setter
    public int EstoqueMinimo
    {
        // Setter define o valor do estoque mínimo
        set { estoqueMinimo = value; }
    }

    // Método para exibir as informações do produto
    public void Exibir()
    {
        // Imprime as informações formatadas na console
        Console.WriteLine($"{Nome} \n{Preco.ToString("c")} \n{Desconto} \n{PrecoFinal.ToString("c")} \n{estoqueMinimo}");
    }
}