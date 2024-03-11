
Calcular cal = new Calcular();

Console.WriteLine(cal.Somar(30, 40));

Console.WriteLine(cal.Somar(30, 40, 50));

class Calcular
{
    public int Somar(int num1, int num2)
    {
        return num1 + num2;
    }
    public int Somar(int num1, int num2, int num3)
    {
        return num1 + num2 + num3;
    }
}
