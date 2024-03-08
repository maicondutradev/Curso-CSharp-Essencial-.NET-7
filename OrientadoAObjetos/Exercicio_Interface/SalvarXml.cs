public class SalvarXml : ArquivoBase, ISalvar
{
    public void Salvar()
    {
        Console.WriteLine("Salvar arquivo XML");
    }
    public override void Nome()
    {
        Console.WriteLine("Definir nome XML");
    }
}