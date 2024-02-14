MinhaPartialClass minhaPartialClass = new MinhaPartialClass();

Console.WriteLine("Idade para nascidos em: 20/04/2000\n");

var idade = minhaPartialClass.CalculaIdade(new DateTime(2000, 4, 20));
Console.WriteLine($"{Math.Round(idade.TotalDays / 365)} anos");

Console.WriteLine("\n Idade para nascidos em: 17/07/2001\n");

var data1 = DateTime.Now;
var data2 = new DateTime(2001, 07, 17);
var diferenca = minhaPartialClass.DiferencaEntreDatas(data1, data2);
Console.WriteLine($"{Math.Round(diferenca.TotalDays / 365)} anos");