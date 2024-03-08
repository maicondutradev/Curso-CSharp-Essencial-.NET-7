namespace Interface;

class Program
{
    static void Main(string[] args)
    {
        SalvarXml salvarXml = new SalvarXml();
        salvarXml.Salvar();
        salvarXml.Nome();


        SalvarJson salvarJson = new SalvarJson();
        salvarJson.Salvar();
        salvarJson.Nome();

        ISalvar compactarXml = new SalvarXml();
        compactarXml.Compactar();

        ISalvar compactarJson = new SalvarJson();
        compactarJson.Compactar();


        Console.ReadKey();

    }
}










