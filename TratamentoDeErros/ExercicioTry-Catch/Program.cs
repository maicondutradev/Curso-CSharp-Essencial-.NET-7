try
{
    // Solicita ao usuário que informe o nome do arquivo e a URL do site.
    Console.WriteLine("Acessando o arquivo poesia.txt em https://macoratti.net/dados \n");
    Console.WriteLine("Informe o nome do arquivo.");
    string? arquivo = Console.ReadLine();

    Console.WriteLine("Informe a url do site.");
    string? url = Console.ReadLine();

    Console.WriteLine("Aguarde...");

    // Cria uma instância do HttpClient para fazer a requisição.
    HttpClient client = new HttpClient();
    HttpResponseMessage response = client.GetAsync(url + "/" + arquivo).Result;

    // Verifica se a resposta da requisição foi bem-sucedida.
    if (response.IsSuccessStatusCode)
    {
        // Exibe mensagem de sucesso e o código de status da resposta.
        Console.WriteLine("O acesso ao arquivo foi feito com sucesso");
        Console.WriteLine("Código de status : " + response.StatusCode);
    }
    else
    {
        // Lança uma exceção específica dependendo do código de status da resposta.
        throw new HttpRequestException("Erro :" + (int)response.StatusCode);
    }
}
catch (HttpRequestException ex) when (ex.Message.Contains("404"))
{
    // Trata o caso em que a página não foi encontrada (código de status 404).
    Console.WriteLine("Página não encontrada");
}
catch (HttpRequestException ex) when (ex.Message.Contains("401"))
{
    // Trata o caso em que o acesso não é autorizado (código de status 401).
    Console.WriteLine("Acesso não autorizado");
}
catch (HttpRequestException ex) when (ex.Message.Contains("400"))
{
    // Trata o caso em que a requisição é inválida (código de status 400).
    Console.WriteLine("Requisição inválida");
}
catch (HttpRequestException ex) when (ex.Message.Contains("500"))
{
    // Trata o caso de erro interno do servidor (código de status 500).
    Console.WriteLine("Erro interno do servidor");
}
catch (Exception ex)
{
    // Trata qualquer outra exceção não prevista nas cláusulas anteriores.
    Console.WriteLine("Erro : " + ex.Message);
}
finally
{
    // Executa as operações que devem ser realizadas independentemente de haver exceções ou não.
    Console.WriteLine("Processamento concluído"); 
}
