Console.WriteLine("## Tramento de números inteiros ##");
Console.WriteLine(" x / y ");

while (true)
{

    Console.WriteLine("\nInforme o valor de x: ");
    int x = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("\nInforme o valor de y: ");
    int y = Convert.ToInt32(Console.ReadLine());

    try
    {
        int z = x / y;
        Console.WriteLine($"\n {x} / {y} = {z}");
    }
    catch (Exception ex)
    {
        Console.WriteLine("Não existe divisão por 0., tente outros valores...");

        Console.WriteLine($"Erro: <<< {ex.Message} >>> ");
        Console.WriteLine($"Erro: <<< {ex?.StackTrace?.ToString()} >>> ");
    }
    finally
    {
        Console.WriteLine("Processamento concluido...");
    }
}