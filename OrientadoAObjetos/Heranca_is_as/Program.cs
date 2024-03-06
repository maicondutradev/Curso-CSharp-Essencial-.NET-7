Object carroObj = new Carro();

var x = carroObj as string;

if (x != null)
{
    Console.WriteLine("A conversão funcionou -> obj para string!");
}
else
{
    Console.WriteLine("A conversão falhou, x é null...");
}

class Carro
{ }