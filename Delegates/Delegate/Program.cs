
var resultado = Calculadora.Somar(5, 5);

Console.WriteLine(resultado);

Console.ReadKey();

DelegateCalculadora calc = new DelegateCalculadora(Calculadora.Somar);
var res = calc.Invoke(20, 30);
Console.WriteLine(res);


public delegate float DelegateCalculadora(float x, float y);