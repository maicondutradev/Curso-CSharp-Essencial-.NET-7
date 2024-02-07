﻿
Email email = new Email();

email.Enviar("saquarema.com.br");
email.Enviar("saquarema.com.br", "Prova final");
email.Enviar("saquarema.com.br", 500);
email.Enviar(500, "Saquarema");

public class Email
{
    public void Enviar(string endereco)
    {
        Console.WriteLine($"{endereco}");
        Console.WriteLine("Assunto padrão");
    }

    public void Enviar(string endereco, string assunto)
    {
        Console.WriteLine($"{endereco}");
        Console.WriteLine($"{assunto}");
    }

    public void Enviar(string endereco, decimal valor)
    {
        Console.WriteLine($"{endereco}");
        Console.WriteLine("Proposta comercial");
        Console.WriteLine(valor);
    }

    public void Enviar(decimal valor, string endereco)
    {
        Console.WriteLine($"{endereco}");
        Console.WriteLine("Pagamento fornecedor");
        Console.WriteLine(valor);
    }
}