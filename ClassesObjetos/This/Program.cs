namespace This
{
    class Program
    {
        static void Main(string[] args)
        {
            Teste t1 = new Teste();
            t1.Num1 = 10;
            t1.Num2 = 20;
            t1.Exibir();

            Teste t2 = new Teste();
            t2.Num1 = 88;
            t2.Num2 = 99;
            t2.Exibir();
        }
    }
}

public class Teste
{
    public int Num1;
    public int Num2;

    public void PassarParametro(Teste t)
    {
        Console.WriteLine($"\nthis = {this}");
        Console.WriteLine($"\nNum1: {t.Num1}");
        Console.WriteLine($"\nNum2: {t.Num2}");
    }

    public void Exibir()
    {
        PassarParametro(this);
    }
}
