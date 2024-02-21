// Definindo uma classe chamada Time
public class Time
{
    // Definindo um array interno com tamanho fixo de 10 elementos para armazenar nomes de times
    string[] valor = new string[10];

    // Implementando um indexador para a classe
    public string this[int i]
    {
        get
        {
            // Verificando se o índice está dentro dos limites válidos do array
            if (i > 0 && i < valor.Length)
            {
                // Retornando o valor do array no índice especificado
                return valor[i];
            }
            // Caso o índice não seja válido, retorna "ERRO"
            return "ERRO";
        }

        set
        {
            // Verificando se o índice está dentro dos limites válidos do array
            if (i > 0 && i < valor.Length)
            {
                // Atribuindo um valor ao array no índice especificado
                valor[i] = value;
            }
        }
    }
}
